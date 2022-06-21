using System;
namespace PhoneNumberAnalysis
{
    using System;

    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            var phone = phoneNumber.Split("-");
            bool IsNewYork = true;
            bool IsFake = false;
            string LocalNumber = phone[2];

            if (phone[0] != "212")
                IsNewYork = false;

            if (phone[1] == "555")
                IsFake = true;

            return (IsNewYork, IsFake, LocalNumber);
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            if (phoneNumberInfo.IsNewYork) return true;
            if (phoneNumberInfo.IsFake) return true;

            return false;
        }
    }

}
