//UseCase é padrão para guardar as regras de nogocio, assim evitando que essas fiquem dentro da controller
using FileTypeChecker.Extensions;
using FileTypeChecker.Types;
using Microsoft.AspNetCore.Http;

namespace CloudStorageTest.Application.UseCases.Users.UploadProfilePhoto;
public class UploadProfilePhotoUseCase
{
    public void Execute(IFormFile file)
    {
        var fileStream = file.OpenReadStream();

        //Verifica tipo especifico(no caso jpeg), retorna true ou false
        var isImage = fileStream.Is<JointPhotographicExpertsGroup> ;

        //Verifica vários típos de imagem
        //var isRecognizableType = FileTypeValidator.IsImage(fileStream);
    }
}
