using Humanizer;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace MyPortfolio.Controllers
{
    public class ProductController : Controller 
    {
        //private readonly IHostingEnvironment _hostingEnvironment;
        //private readonly IServicesType<Project> _projectServices;
        //private readonly ICategoryServices _categoryServices;
        //public static readonly string ProjectPhotoRootPath = "~/Images/Project/";

        //public ProjectController(
        //    IServicesType<Project> projectServices,
        //    ICategoryServices categoryServices,
        //    IHostingEnvironment hostingEnvironment)
        //{
        //    _projectServices = projectServices;
        //    _categoryServices = categoryServices;
        //    _hostingEnvironment = hostingEnvironment;
        //}
        //public async Task<IActionResult> Index() =>
        //    View(await _projectServices.GetAll());

        //public async Task<IActionResult> Details(int id)
        //{

        //    Project project = await _projectServices.Get(id);
        //    if (project == null) 
        //        return RedirectToAction(nameof(Index));
        //    ProjectDetails projectDetails = new()
        //    {
        //        ID = project.,
        //        Name = project.Name,
        //        Description = project.Description,
        //        CreatedOn = project.CreatedOn,
        //        ImageURL = ProjectPhotoRootPath + project.ImageURL,
        //    };

        //    Category cat = await _categoryServices.Get(project.CategoryID);
        //    projectDetails.CategoryName = cat.Name;
        //    return View(projectDetails);
        //}

        //public async Task<IActionResult> Edit(int id)
        //{

        //    Project cat = await _projectServices.Get(id);
        //    if (cat == null)
        //        return RedirectToAction(nameof(Index));

        //    EditProjectViewModel viewModel = new()
        //    {
        //        ID = cat.ID,
        //        Name = cat.Name,
        //        Description = cat.Description,
        //        ExistsPhotoPath = ProjectPhotoRootPath + cat.ImageURL,
        //    };
        //    viewModel.Categories = await _categoryServices.GetAll();
        //    return View(viewModel);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Edit(EditProjectViewModel viewModel)
        //{

        //    if (viewModel == null)
        //    {
        //        viewModel.Categories = await _categoryServices.GetAll();
        //        return RedirectToAction(nameof(Index));
        //    }
                

        //    Project project = await _projectServices.Get(viewModel.ID);
        //    if (viewModel.Image != null)
        //    {
        //        if (!Helper.ImageValidation.IsSizeValid(viewModel.Image))
        //        {
        //            ModelState.AddModelError("Image", "Max Allowed Poster Size Is 2MB");
        //            return View(viewModel);
        //        }
        //        if (!Helper.ImageValidation.IsValidExtensions(viewModel.Image))
        //        {
        //            ModelState.AddModelError("Image", "Only JPG & PNG Extensions Allowed");
        //            return View(viewModel);
        //        }

        //        if (project.ImageURL != null)
        //        {
        //            string path = Path.Combine(_hostingEnvironment.WebRootPath, "Images", "Project", project.ImageURL);
        //            System.IO.File.Delete(path);
        //        }


        //        project.ImageURL = ProcessUploadedFile(viewModel);
        //    }
        //    project.Description = viewModel.Description;
        //    project.Name = viewModel.Name;
        //    _projectServices.Update(project);
        //    return RedirectToAction(nameof(Index));
        //}
        //public async Task< IActionResult> Create()
        //{
        //    CreateProjectViewModel viewModel = new();
        //    viewModel.Categories = await _categoryServices.GetAll();
        //    return View(viewModel);
        //}
        //[HttpPost]
        //public async  Task<IActionResult> Create(CreateProjectViewModel viewModel)
        //{
            
        //    var files = Request.Form.Files;
        //    if (!files.Any())
        //    {
        //        ModelState.AddModelError("Image", "Image is required");
        //        return View(viewModel);
        //    }

        //    if (!Helper.ImageValidation.IsSizeValid(viewModel.Image))
        //    {
        //        ModelState.AddModelError("Image", "Max Allowed Poster Size Is 2MB");
        //        return View(viewModel);
        //    }
        //    if (!Helper.ImageValidation.IsValidExtensions(viewModel.Image))
        //    {
        //        ModelState.AddModelError("Image", "Only JPG & PNG Extensions Allowed");
        //        return View(viewModel);
        //    }

        //    Project project = new()
        //    {
        //        Name = viewModel.Name,
        //        Description = viewModel.Description,
        //        CategoryID = viewModel.CategoryId,
        //        CreatedOn = viewModel.CreatedOn,
                
        //    };
        //    project.ImageURL = ProcessUploadedFile(viewModel);

        //    _projectServices.Create(project);
        //    return RedirectToAction(nameof(Index));
        //}

        //public async Task<IActionResult> Delete(int id)
        //{
        //    Project project = await _projectServices.Get(id);

        //    if (project == null)
        //        return RedirectToAction(nameof(Index));

        //    project.ImageURL = Path.Combine(_hostingEnvironment.WebRootPath, "Images", "Project", project.ImageURL);
        //    _projectServices.Delete(project);

        //    return RedirectToAction(nameof(Index));

        //}

        //private string ProcessUploadedFile(CreateProjectViewModel model)
        //{
        //    string uniqueFileName = null;
        //    if (model.Image != null)
        //    {

        //        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images", "Project");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
        //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //        using (var fileStream = new FileStream(filePath, FileMode.Create))
        //        {
        //            model.Image.CopyTo(fileStream);
        //        }

        //    }

        //    return uniqueFileName;
        //}

    }
}
