﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulerTask.MoviesShowingService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TinyMovieList", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class TinyMovieList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CurrentWeekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<SchedulerTask.MoviesShowingService.TinyMovie> GetMovieByWeekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double NbWeekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SchedulerTask.MoviesShowingService.PagedListOfTinyMoviel_P5pM7zr TinyMoviesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CurrentWeek {
            get {
                return this.CurrentWeekField;
            }
            set {
                if ((this.CurrentWeekField.Equals(value) != true)) {
                    this.CurrentWeekField = value;
                    this.RaisePropertyChanged("CurrentWeek");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SchedulerTask.MoviesShowingService.TinyMovie> GetMovieByWeek {
            get {
                return this.GetMovieByWeekField;
            }
            set {
                if ((object.ReferenceEquals(this.GetMovieByWeekField, value) != true)) {
                    this.GetMovieByWeekField = value;
                    this.RaisePropertyChanged("GetMovieByWeek");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double NbWeek {
            get {
                return this.NbWeekField;
            }
            set {
                if ((this.NbWeekField.Equals(value) != true)) {
                    this.NbWeekField = value;
                    this.RaisePropertyChanged("NbWeek");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SchedulerTask.MoviesShowingService.PagedListOfTinyMoviel_P5pM7zr TinyMovies {
            get {
                return this.TinyMoviesField;
            }
            set {
                if ((object.ReferenceEquals(this.TinyMoviesField, value) != true)) {
                    this.TinyMoviesField = value;
                    this.RaisePropertyChanged("TinyMovies");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PagedListOfTinyMoviel_P5pM7zr", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class PagedListOfTinyMoviel_P5pM7zr : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CurrentPageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<SchedulerTask.MoviesShowingService.TinyMovie> EntityListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalPageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalResultField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Count {
            get {
                return this.CountField;
            }
            set {
                if ((this.CountField.Equals(value) != true)) {
                    this.CountField = value;
                    this.RaisePropertyChanged("Count");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CurrentPage {
            get {
                return this.CurrentPageField;
            }
            set {
                if ((this.CurrentPageField.Equals(value) != true)) {
                    this.CurrentPageField = value;
                    this.RaisePropertyChanged("CurrentPage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SchedulerTask.MoviesShowingService.TinyMovie> EntityList {
            get {
                return this.EntityListField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityListField, value) != true)) {
                    this.EntityListField = value;
                    this.RaisePropertyChanged("EntityList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalPage {
            get {
                return this.TotalPageField;
            }
            set {
                if ((this.TotalPageField.Equals(value) != true)) {
                    this.TotalPageField = value;
                    this.RaisePropertyChanged("TotalPage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalResult {
            get {
                return this.TotalResultField;
            }
            set {
                if ((this.TotalResultField.Equals(value) != true)) {
                    this.TotalResultField = value;
                    this.RaisePropertyChanged("TotalResult");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TinyMovie", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SchedulerTask.MoviesShowingService.Movie))]
    public partial class TinyMovie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ActorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long ApiIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginalTitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PictureUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> PressRatingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ReleaseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrailerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> UserRatingsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Actors {
            get {
                return this.ActorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ActorsField, value) != true)) {
                    this.ActorsField = value;
                    this.RaisePropertyChanged("Actors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ApiId {
            get {
                return this.ApiIdField;
            }
            set {
                if ((this.ApiIdField.Equals(value) != true)) {
                    this.ApiIdField = value;
                    this.RaisePropertyChanged("ApiId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Director {
            get {
                return this.DirectorField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectorField, value) != true)) {
                    this.DirectorField = value;
                    this.RaisePropertyChanged("Director");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OriginalTitle {
            get {
                return this.OriginalTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginalTitleField, value) != true)) {
                    this.OriginalTitleField = value;
                    this.RaisePropertyChanged("OriginalTitle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PictureUrl {
            get {
                return this.PictureUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureUrlField, value) != true)) {
                    this.PictureUrlField = value;
                    this.RaisePropertyChanged("PictureUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> PressRatings {
            get {
                return this.PressRatingsField;
            }
            set {
                if ((this.PressRatingsField.Equals(value) != true)) {
                    this.PressRatingsField = value;
                    this.RaisePropertyChanged("PressRatings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Trailer {
            get {
                return this.TrailerField;
            }
            set {
                if ((object.ReferenceEquals(this.TrailerField, value) != true)) {
                    this.TrailerField = value;
                    this.RaisePropertyChanged("Trailer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> UserRatings {
            get {
                return this.UserRatingsField;
            }
            set {
                if ((this.UserRatingsField.Equals(value) != true)) {
                    this.UserRatingsField = value;
                    this.RaisePropertyChanged("UserRatings");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class Movie : SchedulerTask.MoviesShowingService.TinyMovie {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<SchedulerTask.MoviesShowingService.Link> LinkListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SynopsisField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SchedulerTask.MoviesShowingService.Link> LinkList {
            get {
                return this.LinkListField;
            }
            set {
                if ((object.ReferenceEquals(this.LinkListField, value) != true)) {
                    this.LinkListField = value;
                    this.RaisePropertyChanged("LinkList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Synopsis {
            get {
                return this.SynopsisField;
            }
            set {
                if ((object.ReferenceEquals(this.SynopsisField, value) != true)) {
                    this.SynopsisField = value;
                    this.RaisePropertyChanged("Synopsis");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Link", Namespace="http://schemas.datacontract.org/2004/07/MoviesRememberDomain")]
    [System.SerializableAttribute()]
    public partial class Link : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HrefField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Href {
            get {
                return this.HrefField;
            }
            set {
                if ((object.ReferenceEquals(this.HrefField, value) != true)) {
                    this.HrefField = value;
                    this.RaisePropertyChanged("Href");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MoviesShowingService.IMoviesShowingService")]
    public interface IMoviesShowingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesShowingService/GetNowShowingMoviesByRate", ReplyAction="http://tempuri.org/IMoviesShowingService/GetNowShowingMoviesByRateResponse")]
        SchedulerTask.MoviesShowingService.TinyMovieList GetNowShowingMoviesByRate(int numPage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesShowingService/GetNowShowingMoviesByDate", ReplyAction="http://tempuri.org/IMoviesShowingService/GetNowShowingMoviesByDateResponse")]
        SchedulerTask.MoviesShowingService.TinyMovieList GetNowShowingMoviesByDate(int numPage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesShowingService/GetComingSoonMoviesByRate", ReplyAction="http://tempuri.org/IMoviesShowingService/GetComingSoonMoviesByRateResponse")]
        SchedulerTask.MoviesShowingService.TinyMovieList GetComingSoonMoviesByRate(int numPage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesShowingService/GetComingSoonMoviesByDate", ReplyAction="http://tempuri.org/IMoviesShowingService/GetComingSoonMoviesByDateResponse")]
        SchedulerTask.MoviesShowingService.TinyMovieList GetComingSoonMoviesByDate(int numPage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesShowingService/GetBestWeekMovies", ReplyAction="http://tempuri.org/IMoviesShowingService/GetBestWeekMoviesResponse")]
        System.Collections.Generic.List<SchedulerTask.MoviesShowingService.TinyMovie> GetBestWeekMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMoviesShowingService/GetMovie", ReplyAction="http://tempuri.org/IMoviesShowingService/GetMovieResponse")]
        SchedulerTask.MoviesShowingService.Movie GetMovie(long code);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMoviesShowingServiceChannel : SchedulerTask.MoviesShowingService.IMoviesShowingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MoviesShowingServiceClient : System.ServiceModel.ClientBase<SchedulerTask.MoviesShowingService.IMoviesShowingService>, SchedulerTask.MoviesShowingService.IMoviesShowingService {
        
        public MoviesShowingServiceClient() {
        }
        
        public MoviesShowingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MoviesShowingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesShowingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesShowingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SchedulerTask.MoviesShowingService.TinyMovieList GetNowShowingMoviesByRate(int numPage) {
            return base.Channel.GetNowShowingMoviesByRate(numPage);
        }
        
        public SchedulerTask.MoviesShowingService.TinyMovieList GetNowShowingMoviesByDate(int numPage) {
            return base.Channel.GetNowShowingMoviesByDate(numPage);
        }
        
        public SchedulerTask.MoviesShowingService.TinyMovieList GetComingSoonMoviesByRate(int numPage) {
            return base.Channel.GetComingSoonMoviesByRate(numPage);
        }
        
        public SchedulerTask.MoviesShowingService.TinyMovieList GetComingSoonMoviesByDate(int numPage) {
            return base.Channel.GetComingSoonMoviesByDate(numPage);
        }
        
        public System.Collections.Generic.List<SchedulerTask.MoviesShowingService.TinyMovie> GetBestWeekMovies() {
            return base.Channel.GetBestWeekMovies();
        }
        
        public SchedulerTask.MoviesShowingService.Movie GetMovie(long code) {
            return base.Channel.GetMovie(code);
        }
    }
}
