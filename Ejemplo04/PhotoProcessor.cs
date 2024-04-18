using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo04
{
    public class PhotoProcessor
    {
        private readonly IRepository<string> _repository;
        public PhotoProcessor (IRepository<string>repository)
        {
            _repository = repository;

        }
        public void CopyPhotoInPallel()
        {
            List<string> photoPath = _repository.GetAll();
            Parallel.ForEach(photoPath, photo =>
            {
                string fileName=Path.GetFileName(photo);
                string destinationPath=Path.Combine(_repository.GetDestiantionFolder(), fileName);
                _repository.Copy(photo, destinationPath);
                Console.WriteLine($"Copied photo:{fileName} in thread{Task.CurrentId}");

            }
            );
        }
    }
}
