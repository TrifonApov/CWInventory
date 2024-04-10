namespace CWInventory.Infrastructure.Constants
{
    public static class DataConstants
    {
        public const int NameMinimumLength = 3;
        public const int NameMaximumLength = 100;

        public const int DescriptionMinimumLength = 10;
        public const int DescriptionMaximumLength = 500;

        public const int PhoneNumberMinimumLenght = 10;
        public const int PhoneNumberMaximumLenght = 20;

        public const string RequiredErrorMessage = "The field {0} is required";
        public const string LengthErrorMessage = "The field {0} must be between {2} and {1} characters long";
    }
}
