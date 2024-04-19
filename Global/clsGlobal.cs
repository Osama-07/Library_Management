using LibraryBusiness;
using System.Reflection;
using System.Configuration;
using Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Library_Management.Global
{
    public class clsGlobal
    {
        private static string _SourceName = Assembly.GetExecutingAssembly().GetName().Name;
        private static string _Location = Assembly.GetExecutingAssembly().Location; // 
        private static string _DestinationFolder = @"D:\Library_Management_Images\"; // folder for save books images.

        public static clsUtil Util = new clsUtil(_SourceName, _Location, _DestinationFolder);

        private static string _SenderEmail = ConfigurationManager.AppSettings["SenderEmail"];
        private static string _AppPass = ConfigurationManager.AppSettings["AppPass"];

        private static clsEmail _Email = new clsEmail(_SenderEmail, _AppPass);

        public static clsUsers CurrentUser 
        { 
            get
            {
                return clsUsers.FindByUser_ID(1);
            }
        }

        public static bool SendFineEmail(int UserID, int FineID)
        {
            string RecepientEmail = clsUsers.FindByUser_ID(UserID).Email;
            string Username = clsUsers.FindByUser_ID(UserID).Name;
            int fineAmount = Convert.ToInt32(clsFines.FindByFine_ID(FineID).FinesAmount);
            
            _Email.RecipientEmail = RecepientEmail;
            _Email.Subject = "إشعار بفرض غرامة على تأخير تسليم الكتاب";
            _Email.Body = $@"
مرحبًا {Username},

آمل أن تكون بخير. نود إبلاغك بأننا قد استلمنا الكتاب الذي قمت بإعادته، ولكن بعد التحقق تبين أنه تأخر في التسليم بموجب شروطنا.

نظرًا للتأخير في التسليم، نأسف لإبلاغك بأنه تم فرض غرامة بمبلغ {fineAmount} على حسابك. يجب دفع الغرامة قبل أن تتمكن من استعارة أي كتب أخرى.

يرجى مراجعة الشروط والأحكام الخاصة بتسليم الكتب والغرامات لتجنب هذه المشكلة في المستقبل.

إذا كان لديك أي استفسارات أو تحتاج إلى مزيد من التوضيح، فلا تتردد في التواصل معنا. نحن هنا لمساعدتك.

نحن نقدر تفهمك وتعاونك في هذا الشأن، ونأمل أن تستمر بالاستفادة من خدماتنا في المستقبل.

مع أطيب التحيات،

[أسامه عبدالعزيز]
[المدير التنفيذي]
[Osama7.ya@gmail.com]";
            
            return _Email.Send();
        }

        public static bool SendPaymentConfirmationEmail(int UserID, int FineID)
        {
            string RecepientEmail = clsUsers.FindByUser_ID(UserID).Email;
            string Username = clsUsers.FindByUser_ID(UserID).Name;
            int fineAmount = Convert.ToInt32(clsFines.FindByFine_ID(FineID).FinesAmount);

            _Email.RecipientEmail = RecepientEmail;
            _Email.Subject = "تأكيد دفع الغرامة";
            _Email.Body = $@"
مرحبًا {Username},

نود أن نعلمك بأنه تم دفع الغرامة بنجاح على حسابك بمبلغ {fineAmount}.

يرجى التواصل معنا إذا كان لديك أي استفسارات أو تحتاج إلى مزيد من المساعدة.

شكرًا لتفهمك وتعاونك معنا.

مع أطيب التحيات،

[أسامه عبدالعزيز]
[المدير التنفيذي]
[Osama7.ya@gmail.com]";

            return _Email.Send();
        }

        public static bool SendBorrowConfirmationEmail(int UserID, int BookID)
        {
            string RecepientEmail = clsUsers.FindByUser_ID(UserID).Email;
            string Username = clsUsers.FindByUser_ID(UserID).Name;
            string BookTitle = clsBooks.FindByBook_ID(BookID).Title;
            DateTime borrowDate = clsBorrowingRecords.FindByUser_ID(UserID).BorrowingDate;
            DateTime dueDate = clsBorrowingRecords.FindByUser_ID(UserID).DueDate;

            _Email.RecipientEmail = RecepientEmail;
            _Email.Subject = "تأكيد استعارة الكتاب";
            _Email.Body = $@"
مرحبًا {Username},

نود أن نعلمك بأنك قمت بنجاح بإستعارة الكتاب بعنوان {BookTitle}.

تاريخ الاستعارة: {borrowDate.ToShortDateString()}
تاريخ الاستحقاق: {dueDate.ToShortDateString()}

يرجى إعادة الكتاب في الموعد المحدد لتجنب أي غرامات.

إذا كان لديك أي استفسارات أو تحتاج إلى مساعدة، فلا تتردد في التواصل معنا.

مع أطيب التحيات،

[أسامه عبدالعزيز]
[المدير التنفيذي]
[Osama7.ya@gmail.com]";

            return _Email.Send();
        }

        public static bool SendReturnConfirmationEmail(int UserID, int BookID)
        {
            string RecepientEmail = clsUsers.FindByUser_ID(UserID).Email;
            string Username = clsUsers.FindByUser_ID(UserID).Name;
            string BookTitle = clsBooks.FindByBook_ID(BookID).Title;

            _Email.RecipientEmail = RecepientEmail;
            _Email.Subject = "تأكيد إعادة الكتاب";
            _Email.Body = $@"
مرحبًا {Username},

نود أن نعلمك بأنك قمت بنجاح بإعادة الكتاب بعنوان {BookTitle}.

شكرًا للالتزام بشروط إعادة الكتاب في الوقت المناسب.

إذا كان لديك أي استفسارات أو تحتاج إلى مساعدة، فلا تتردد في التواصل معنا.

مع أطيب التحيات،

[أسامه عبدالعزيز]
[المدير التنفيذي]
[Osama7.ya@gmail.com]";

            return _Email.Send();
        }

        public static bool SendVerificationEmail(string recipientEmail, string verificationCode)
        {
            _Email.RecipientEmail = recipientEmail;
            _Email.Subject = "تأكيد البريد الإلكتروني";
            _Email.Body = $@"
مرحبًا،

شكرًا لتسجيلك معنا. لإكمال عملية التسجيل، يرجى استخدام الرمز التالي:

رمز التحقق: {verificationCode}

يرجى إدخال هذا الرمز في الصفحة التي قمت بالتسجيل من خلالها للتحقق من عنوان بريدك الإلكتروني.

إذا لم تقم بطلب إنشاء حساب معنا، فتجاهل هذا البريد الإلكتروني.

مع تحياتنا،
[اسم المنظمة/الشركة]";

            return _Email.Send();
        }

        public static bool SendRegistrationConfirmationEmail(int UserID)
        {
            string RecepientEmail = clsUsers.FindByUser_ID(UserID).Email;
            string Username = clsUsers.FindByUser_ID(UserID).Name;

            _Email.RecipientEmail = RecepientEmail;
            _Email.Subject = "تم التسجيل بنجاح";
            _Email.Body = $@"
مرحبًا {Username},

تم تسجيل حسابك بنجاح. نحن سعداء بانضمامك إلى مجتمعنا!

شكرًا لثقتك بنا. يمكنك الآن البدء في الاستفادة من خدماتنا والتفاعل مع المحتوى الخاص بنا.

إذا كان لديك أي استفسارات أو تحتاج إلى مساعدة، فلا تتردد في التواصل معنا.

مع أطيب التحيات،

[أسامه عبدالعزيز]
[المدير التنفيذي]
[Osama7.ya@gmail.com]";

            return _Email.Send();
        }

        public static bool SendProfileUpdateConfirmationEmail(int UserID)
        {
            string RecepientEmail = clsUsers.FindByUser_ID(UserID).Email;
            string Username = clsUsers.FindByUser_ID(UserID).Name;

            _Email.RecipientEmail = RecepientEmail;
            _Email.Subject = "تأكيد تعديل معلومات المستخدم";
            _Email.Body = $@"
مرحبًا {Username},

تم تعديل معلومات حسابك بنجاح. تم تحديث المعلومات بنجاح وفقًا للتغييرات التي قمت بها.

إذا لم تكن أنت من قام بتعديل المعلومات، يرجى التواصل معنا على الفور لمعرفة المزيد حول هذا التعديل.

إذا كان لديك أي استفسارات أو تحتاج إلى مساعدة، فلا تتردد في التواصل معنا.

مع أطيب التحيات،

[أسامه عبدالعزيز]
[المدير التنفيذي]
[Osama7.ya@gmail.com]";

            return _Email.Send();
        }

        public static bool SendMessageEmail()
        {
            return true;
        }


        // this for store path of images changed, and delete them when close the program.
        public static List<string> ImagesPathForDelete = new List<string>();
        public static async void DeleteImagesChanged()
        {
            try
            {
                foreach (string Image in ImagesPathForDelete)
                {
                    await Task.Run(() => File.Delete(Image));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
    }
}
