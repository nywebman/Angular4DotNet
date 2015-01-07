
using Angular4DotNet.Models.Courses;
using Angular4DotNet.Models.Instructors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Angular4DotNet.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public RegistrationVm BuildRegistrationVm()
        {
            var registrationVm = new RegistrationVm()
            {
                Courses = GetSerializedCourses(),
                Instructors = GetSerializedInstructors()
            };
            return registrationVm;
        }
        public string GetSerializedCourses()
        {
            var courses = new[]
            {
                new CourseVm {Number = "CREA101", Name = "care of Creatures", Instructor = "r hagrid"},
                new CourseVm {Number = "DARK502", Name = "defence of dark arts", Instructor = "Snape"},
                new CourseVm {Number = "TRAN201", Name = "Transfiguration", Instructor = "Mcconagal"}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializeCourses = JsonConvert.SerializeObject(courses, Formatting.None, settings);
            return serializeCourses;
        }
        public string GetSerializedInstructors()
        {
            var instructors = new[]
            {
                new InstructorVm {Name = "R Hagrid",Email = "hagrid@hogwarts.com",RoomNumber = 1001},
                new InstructorVm {Name = "S Snape",Email = "snape@hogwarts.com",RoomNumber = 1065},
                new InstructorVm {Name = "M McGonagal",Email = "mcconagal@hogwarts.com",RoomNumber = 102}
            };
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var serializedInstructors = JsonConvert.SerializeObject(instructors, Formatting.None, settings);
            return serializedInstructors;
        }
    }
}