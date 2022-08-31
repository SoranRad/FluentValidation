using System.ComponentModel.DataAnnotations;
using FluentValidation;
using WebApp.Attribute;

namespace WebApp.ViewModels
{
    public class FileValidationViewModel
    {
        [DataType(DataType.Upload)]
        public IFormFile Logo { get; set; }
    }


    public class FileValidationViewModelValidator : AbstractValidator<FileValidationViewModel>
    {
        public FileValidationViewModelValidator()
        {
            var fileValidator = new FileValidation<FileValidationViewModel, IFormFile>()
            {
                IsRequied                       = false,
                RequiredErrorMessage            = "Please, select your logo",
                MaximumFileSize                 = 2 * 1024 * 1024,
                MaximumFileSizeErrorMessage     = "Your file is too big",
                ExtensionAcceptable             = "jpg,bmp,png",
                ExtensionAcceptableErrorMessage = "Your logo not supported"
            };

            RuleFor(x => x.Logo)
                .SetValidator(fileValidator);
        }
    }


}
