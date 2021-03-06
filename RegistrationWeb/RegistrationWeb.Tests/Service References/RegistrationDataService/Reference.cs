﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationWeb.Tests.RegistrationDataService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RegistrationDataService.IRegistrationDataService")]
    public interface IRegistrationDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetStudents", ReplyAction="http://tempuri.org/IRegistrationDataService/GetStudentsResponse")]
        RegistrationWeb.Client.RegistrationDataService.StudentDAO[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetStudents", ReplyAction="http://tempuri.org/IRegistrationDataService/GetStudentsResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.StudentDAO[]> GetStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetStudentsUsers", ReplyAction="http://tempuri.org/IRegistrationDataService/GetStudentsUsersResponse")]
        RegistrationWeb.Client.RegistrationDataService.StudentUserDAO[] GetStudentsUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetStudentsUsers", ReplyAction="http://tempuri.org/IRegistrationDataService/GetStudentsUsersResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.StudentUserDAO[]> GetStudentsUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetRegistrarUsers", ReplyAction="http://tempuri.org/IRegistrationDataService/GetRegistrarUsersResponse")]
        RegistrationWeb.Client.RegistrationDataService.RegistrarUserDAO[] GetRegistrarUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetRegistrarUsers", ReplyAction="http://tempuri.org/IRegistrationDataService/GetRegistrarUsersResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.RegistrarUserDAO[]> GetRegistrarUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetCourses", ReplyAction="http://tempuri.org/IRegistrationDataService/GetCoursesResponse")]
        RegistrationWeb.Client.RegistrationDataService.CourseDAO[] GetCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetCourses", ReplyAction="http://tempuri.org/IRegistrationDataService/GetCoursesResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.CourseDAO[]> GetCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetSessions", ReplyAction="http://tempuri.org/IRegistrationDataService/GetSessionsResponse")]
        RegistrationWeb.Client.RegistrationDataService.CourseSessionDAO[] GetSessions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetSessions", ReplyAction="http://tempuri.org/IRegistrationDataService/GetSessionsResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.CourseSessionDAO[]> GetSessionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/RegisterStudent", ReplyAction="http://tempuri.org/IRegistrationDataService/RegisterStudentResponse")]
        bool RegisterStudent(int studentId, int sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/RegisterStudent", ReplyAction="http://tempuri.org/IRegistrationDataService/RegisterStudentResponse")]
        System.Threading.Tasks.Task<bool> RegisterStudentAsync(int studentId, int sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/DropFromSession", ReplyAction="http://tempuri.org/IRegistrationDataService/DropFromSessionResponse")]
        bool DropFromSession(int studentId, int sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/DropFromSession", ReplyAction="http://tempuri.org/IRegistrationDataService/DropFromSessionResponse")]
        System.Threading.Tasks.Task<bool> DropFromSessionAsync(int studentId, int sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/AddCourseBookmark", ReplyAction="http://tempuri.org/IRegistrationDataService/AddCourseBookmarkResponse")]
        bool AddCourseBookmark(RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO bookmarkToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/AddCourseBookmark", ReplyAction="http://tempuri.org/IRegistrationDataService/AddCourseBookmarkResponse")]
        System.Threading.Tasks.Task<bool> AddCourseBookmarkAsync(RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO bookmarkToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/RemoveCourseBookmark", ReplyAction="http://tempuri.org/IRegistrationDataService/RemoveCourseBookmarkResponse")]
        bool RemoveCourseBookmark(RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO bookmarkToRemove);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/RemoveCourseBookmark", ReplyAction="http://tempuri.org/IRegistrationDataService/RemoveCourseBookmarkResponse")]
        System.Threading.Tasks.Task<bool> RemoveCourseBookmarkAsync(RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO bookmarkToRemove);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetBookmarks", ReplyAction="http://tempuri.org/IRegistrationDataService/GetBookmarksResponse")]
        RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO[] GetBookmarks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetBookmarks", ReplyAction="http://tempuri.org/IRegistrationDataService/GetBookmarksResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO[]> GetBookmarksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetSchedules", ReplyAction="http://tempuri.org/IRegistrationDataService/GetSchedulesResponse")]
        RegistrationWeb.Client.RegistrationDataService.ScheduleDAO[] GetSchedules();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetSchedules", ReplyAction="http://tempuri.org/IRegistrationDataService/GetSchedulesResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.ScheduleDAO[]> GetSchedulesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/InsertCourse", ReplyAction="http://tempuri.org/IRegistrationDataService/InsertCourseResponse")]
        bool InsertCourse(RegistrationWeb.Client.RegistrationDataService.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/InsertCourse", ReplyAction="http://tempuri.org/IRegistrationDataService/InsertCourseResponse")]
        System.Threading.Tasks.Task<bool> InsertCourseAsync(RegistrationWeb.Client.RegistrationDataService.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/CancelCourse", ReplyAction="http://tempuri.org/IRegistrationDataService/CancelCourseResponse")]
        bool CancelCourse(RegistrationWeb.Client.RegistrationDataService.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/CancelCourse", ReplyAction="http://tempuri.org/IRegistrationDataService/CancelCourseResponse")]
        System.Threading.Tasks.Task<bool> CancelCourseAsync(RegistrationWeb.Client.RegistrationDataService.CourseDAO course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/InsertStudent", ReplyAction="http://tempuri.org/IRegistrationDataService/InsertStudentResponse")]
        bool InsertStudent(RegistrationWeb.Client.RegistrationDataService.StudentDAO student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/InsertStudent", ReplyAction="http://tempuri.org/IRegistrationDataService/InsertStudentResponse")]
        System.Threading.Tasks.Task<bool> InsertStudentAsync(RegistrationWeb.Client.RegistrationDataService.StudentDAO student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/RemoveStudent", ReplyAction="http://tempuri.org/IRegistrationDataService/RemoveStudentResponse")]
        bool RemoveStudent(RegistrationWeb.Client.RegistrationDataService.StudentDAO student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/RemoveStudent", ReplyAction="http://tempuri.org/IRegistrationDataService/RemoveStudentResponse")]
        System.Threading.Tasks.Task<bool> RemoveStudentAsync(RegistrationWeb.Client.RegistrationDataService.StudentDAO student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetStudentSchedule", ReplyAction="http://tempuri.org/IRegistrationDataService/GetStudentScheduleResponse")]
        RegistrationWeb.Client.RegistrationDataService.CourseSessionDAO[] GetStudentSchedule(int studentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/GetStudentSchedule", ReplyAction="http://tempuri.org/IRegistrationDataService/GetStudentScheduleResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.CourseSessionDAO[]> GetStudentScheduleAsync(int studentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/ListEnrolledStudents", ReplyAction="http://tempuri.org/IRegistrationDataService/ListEnrolledStudentsResponse")]
        RegistrationWeb.Client.RegistrationDataService.StudentDAO[] ListEnrolledStudents(int sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistrationDataService/ListEnrolledStudents", ReplyAction="http://tempuri.org/IRegistrationDataService/ListEnrolledStudentsResponse")]
        System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.StudentDAO[]> ListEnrolledStudentsAsync(int sessionId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRegistrationDataServiceChannel : RegistrationWeb.Tests.RegistrationDataService.IRegistrationDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegistrationDataServiceClient : System.ServiceModel.ClientBase<RegistrationWeb.Tests.RegistrationDataService.IRegistrationDataService>, RegistrationWeb.Tests.RegistrationDataService.IRegistrationDataService {
        
        public RegistrationDataServiceClient() {
        }
        
        public RegistrationDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegistrationDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrationDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RegistrationWeb.Client.RegistrationDataService.StudentDAO[] GetStudents() {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.StudentDAO[]> GetStudentsAsync() {
            return base.Channel.GetStudentsAsync();
        }
        
        public RegistrationWeb.Client.RegistrationDataService.StudentUserDAO[] GetStudentsUsers() {
            return base.Channel.GetStudentsUsers();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.StudentUserDAO[]> GetStudentsUsersAsync() {
            return base.Channel.GetStudentsUsersAsync();
        }
        
        public RegistrationWeb.Client.RegistrationDataService.RegistrarUserDAO[] GetRegistrarUsers() {
            return base.Channel.GetRegistrarUsers();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.RegistrarUserDAO[]> GetRegistrarUsersAsync() {
            return base.Channel.GetRegistrarUsersAsync();
        }
        
        public RegistrationWeb.Client.RegistrationDataService.CourseDAO[] GetCourses() {
            return base.Channel.GetCourses();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.CourseDAO[]> GetCoursesAsync() {
            return base.Channel.GetCoursesAsync();
        }
        
        public RegistrationWeb.Client.RegistrationDataService.CourseSessionDAO[] GetSessions() {
            return base.Channel.GetSessions();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.CourseSessionDAO[]> GetSessionsAsync() {
            return base.Channel.GetSessionsAsync();
        }
        
        public bool RegisterStudent(int studentId, int sessionId) {
            return base.Channel.RegisterStudent(studentId, sessionId);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterStudentAsync(int studentId, int sessionId) {
            return base.Channel.RegisterStudentAsync(studentId, sessionId);
        }
        
        public bool DropFromSession(int studentId, int sessionId) {
            return base.Channel.DropFromSession(studentId, sessionId);
        }
        
        public System.Threading.Tasks.Task<bool> DropFromSessionAsync(int studentId, int sessionId) {
            return base.Channel.DropFromSessionAsync(studentId, sessionId);
        }
        
        public bool AddCourseBookmark(RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO bookmarkToAdd) {
            return base.Channel.AddCourseBookmark(bookmarkToAdd);
        }
        
        public System.Threading.Tasks.Task<bool> AddCourseBookmarkAsync(RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO bookmarkToAdd) {
            return base.Channel.AddCourseBookmarkAsync(bookmarkToAdd);
        }
        
        public bool RemoveCourseBookmark(RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO bookmarkToRemove) {
            return base.Channel.RemoveCourseBookmark(bookmarkToRemove);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveCourseBookmarkAsync(RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO bookmarkToRemove) {
            return base.Channel.RemoveCourseBookmarkAsync(bookmarkToRemove);
        }
        
        public RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO[] GetBookmarks() {
            return base.Channel.GetBookmarks();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.BookmarkedSessionDAO[]> GetBookmarksAsync() {
            return base.Channel.GetBookmarksAsync();
        }
        
        public RegistrationWeb.Client.RegistrationDataService.ScheduleDAO[] GetSchedules() {
            return base.Channel.GetSchedules();
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.ScheduleDAO[]> GetSchedulesAsync() {
            return base.Channel.GetSchedulesAsync();
        }
        
        public bool InsertCourse(RegistrationWeb.Client.RegistrationDataService.CourseDAO course) {
            return base.Channel.InsertCourse(course);
        }
        
        public System.Threading.Tasks.Task<bool> InsertCourseAsync(RegistrationWeb.Client.RegistrationDataService.CourseDAO course) {
            return base.Channel.InsertCourseAsync(course);
        }
        
        public bool CancelCourse(RegistrationWeb.Client.RegistrationDataService.CourseDAO course) {
            return base.Channel.CancelCourse(course);
        }
        
        public System.Threading.Tasks.Task<bool> CancelCourseAsync(RegistrationWeb.Client.RegistrationDataService.CourseDAO course) {
            return base.Channel.CancelCourseAsync(course);
        }
        
        public bool InsertStudent(RegistrationWeb.Client.RegistrationDataService.StudentDAO student) {
            return base.Channel.InsertStudent(student);
        }
        
        public System.Threading.Tasks.Task<bool> InsertStudentAsync(RegistrationWeb.Client.RegistrationDataService.StudentDAO student) {
            return base.Channel.InsertStudentAsync(student);
        }
        
        public bool RemoveStudent(RegistrationWeb.Client.RegistrationDataService.StudentDAO student) {
            return base.Channel.RemoveStudent(student);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveStudentAsync(RegistrationWeb.Client.RegistrationDataService.StudentDAO student) {
            return base.Channel.RemoveStudentAsync(student);
        }
        
        public RegistrationWeb.Client.RegistrationDataService.CourseSessionDAO[] GetStudentSchedule(int studentId) {
            return base.Channel.GetStudentSchedule(studentId);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.CourseSessionDAO[]> GetStudentScheduleAsync(int studentId) {
            return base.Channel.GetStudentScheduleAsync(studentId);
        }
        
        public RegistrationWeb.Client.RegistrationDataService.StudentDAO[] ListEnrolledStudents(int sessionId) {
            return base.Channel.ListEnrolledStudents(sessionId);
        }
        
        public System.Threading.Tasks.Task<RegistrationWeb.Client.RegistrationDataService.StudentDAO[]> ListEnrolledStudentsAsync(int sessionId) {
            return base.Channel.ListEnrolledStudentsAsync(sessionId);
        }
    }
}
