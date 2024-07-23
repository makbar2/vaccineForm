using System.ComponentModel.DataAnnotations;
    /// <summary>
    /// This validation is to check if the user has selected an option on the radio text as the default value of the 
    /// attributes in the patientmedicalhistory model is null, which is is then used for the radio text component,
    /// as if the value is null then the radio wont have a value assigned to it(meaning either yes and no isnt selected).
    /// an empty string means that the user has pressed yes and hasnt provided any extra information about it
    /// </summary>
    /// <returns>
    /// </returns>
    /// <remarks>
    /// </remarks>
public class NotNullValidation : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
        {
            var errorMessage = string.IsNullOrEmpty(ErrorMessage) ? "Please select an option." : ErrorMessage;
            return new ValidationResult(errorMessage);
        }
        
        return ValidationResult.Success;
    }
}
