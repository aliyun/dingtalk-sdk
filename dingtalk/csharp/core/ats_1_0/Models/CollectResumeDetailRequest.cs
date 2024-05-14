// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectResumeDetailRequest : TeaModel {
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        [NameInMap("channelOuterId")]
        [Validation(Required=false)]
        public string ChannelOuterId { get; set; }

        [NameInMap("channelTalentId")]
        [Validation(Required=false)]
        public string ChannelTalentId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deliverJobId")]
        [Validation(Required=false)]
        public string DeliverJobId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        [NameInMap("resumeChannelUrl")]
        [Validation(Required=false)]
        public string ResumeChannelUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resumeData")]
        [Validation(Required=false)]
        public CollectResumeDetailRequestResumeData ResumeData { get; set; }
        public class CollectResumeDetailRequestResumeData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("baseInfo")]
            [Validation(Required=false)]
            public CollectResumeDetailRequestResumeDataBaseInfo BaseInfo { get; set; }
            public class CollectResumeDetailRequestResumeDataBaseInfo : TeaModel {
                [NameInMap("age")]
                [Validation(Required=false)]
                public int? Age { get; set; }

                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("beginWorkTime")]
                [Validation(Required=false)]
                public string BeginWorkTime { get; set; }

                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("englishName")]
                [Validation(Required=false)]
                public string EnglishName { get; set; }

                [NameInMap("graduateTime")]
                [Validation(Required=false)]
                public string GraduateTime { get; set; }

                [NameInMap("highestEducation")]
                [Validation(Required=false)]
                public int? HighestEducation { get; set; }

                [NameInMap("jobTitle")]
                [Validation(Required=false)]
                public string JobTitle { get; set; }

                [NameInMap("lastSchoolName")]
                [Validation(Required=false)]
                public string LastSchoolName { get; set; }

                [NameInMap("married")]
                [Validation(Required=false)]
                public int? Married { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nativePlace")]
                [Validation(Required=false)]
                public string NativePlace { get; set; }

                [NameInMap("nowLocation")]
                [Validation(Required=false)]
                public string NowLocation { get; set; }

                [NameInMap("personalHonor")]
                [Validation(Required=false)]
                public string PersonalHonor { get; set; }

                [NameInMap("phoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                [NameInMap("politicalStatus")]
                [Validation(Required=false)]
                public int? PoliticalStatus { get; set; }

                [NameInMap("selfEvaluation")]
                [Validation(Required=false)]
                public string SelfEvaluation { get; set; }

                [NameInMap("sex")]
                [Validation(Required=false)]
                public int? Sex { get; set; }

                [NameInMap("virtualPhoneNum")]
                [Validation(Required=false)]
                public string VirtualPhoneNum { get; set; }

                [NameInMap("workingYears")]
                [Validation(Required=false)]
                public int? WorkingYears { get; set; }

            }

            [NameInMap("certificates")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataCertificates> Certificates { get; set; }
            public class CollectResumeDetailRequestResumeDataCertificates : TeaModel {
                [NameInMap("certificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                [NameInMap("grantTime")]
                [Validation(Required=false)]
                public string GrantTime { get; set; }

            }

            [NameInMap("educationExperiences")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataEducationExperiences> EducationExperiences { get; set; }
            public class CollectResumeDetailRequestResumeDataEducationExperiences : TeaModel {
                [NameInMap("degree")]
                [Validation(Required=false)]
                public int? Degree { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("major")]
                [Validation(Required=false)]
                public string Major { get; set; }

                [NameInMap("schoolName")]
                [Validation(Required=false)]
                public string SchoolName { get; set; }

                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            [NameInMap("jobExpect")]
            [Validation(Required=false)]
            public CollectResumeDetailRequestResumeDataJobExpect JobExpect { get; set; }
            public class CollectResumeDetailRequestResumeDataJobExpect : TeaModel {
                [NameInMap("jobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                [NameInMap("locations")]
                [Validation(Required=false)]
                public List<string> Locations { get; set; }

                [NameInMap("maxSalary")]
                [Validation(Required=false)]
                public string MaxSalary { get; set; }

                [NameInMap("minSalary")]
                [Validation(Required=false)]
                public string MinSalary { get; set; }

                [NameInMap("onboardTime")]
                [Validation(Required=false)]
                public string OnboardTime { get; set; }

            }

            [NameInMap("languageSkill")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataLanguageSkill> LanguageSkill { get; set; }
            public class CollectResumeDetailRequestResumeDataLanguageSkill : TeaModel {
                [NameInMap("certificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                [NameInMap("languageName")]
                [Validation(Required=false)]
                public string LanguageName { get; set; }

            }

            [NameInMap("trainingExperiences")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataTrainingExperiences> TrainingExperiences { get; set; }
            public class CollectResumeDetailRequestResumeDataTrainingExperiences : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("institutionName")]
                [Validation(Required=false)]
                public string InstitutionName { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            [NameInMap("workExperiences")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataWorkExperiences> WorkExperiences { get; set; }
            public class CollectResumeDetailRequestResumeDataWorkExperiences : TeaModel {
                [NameInMap("companyName")]
                [Validation(Required=false)]
                public string CompanyName { get; set; }

                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("jobTitle")]
                [Validation(Required=false)]
                public string JobTitle { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("responsibility")]
                [Validation(Required=false)]
                public string Responsibility { get; set; }

                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

        }

        [NameInMap("resumeFile")]
        [Validation(Required=false)]
        public CollectResumeDetailRequestResumeFile ResumeFile { get; set; }
        public class CollectResumeDetailRequestResumeFile : TeaModel {
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

        }

    }

}
