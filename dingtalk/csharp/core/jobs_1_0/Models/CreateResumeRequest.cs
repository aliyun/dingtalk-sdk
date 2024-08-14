// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkjobs_1_0.Models
{
    public class CreateResumeRequest : TeaModel {
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        [NameInMap("resumeDataVO")]
        [Validation(Required=false)]
        public CreateResumeRequestResumeDataVO ResumeDataVO { get; set; }
        public class CreateResumeRequestResumeDataVO : TeaModel {
            [NameInMap("baseInfo")]
            [Validation(Required=false)]
            public CreateResumeRequestResumeDataVOBaseInfo BaseInfo { get; set; }
            public class CreateResumeRequestResumeDataVOBaseInfo : TeaModel {
                [NameInMap("age")]
                [Validation(Required=false)]
                public long? Age { get; set; }

                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("beginWorkTime")]
                [Validation(Required=false)]
                public string BeginWorkTime { get; set; }

                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                [NameInMap("candidateBackground")]
                [Validation(Required=false)]
                public int? CandidateBackground { get; set; }

                [NameInMap("dingTalk")]
                [Validation(Required=false)]
                public string DingTalk { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("englishName")]
                [Validation(Required=false)]
                public string EnglishName { get; set; }

                [NameInMap("ethnicity")]
                [Validation(Required=false)]
                public string Ethnicity { get; set; }

                [NameInMap("gaduateTime")]
                [Validation(Required=false)]
                public string GaduateTime { get; set; }

                [NameInMap("highestAcademic")]
                [Validation(Required=false)]
                public string HighestAcademic { get; set; }

                [NameInMap("highestEducation")]
                [Validation(Required=false)]
                public int? HighestEducation { get; set; }

                [NameInMap("identify")]
                [Validation(Required=false)]
                public string Identify { get; set; }

                [NameInMap("industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                [NameInMap("industryCode")]
                [Validation(Required=false)]
                public string IndustryCode { get; set; }

                [NameInMap("jobTitle")]
                [Validation(Required=false)]
                public string JobTitle { get; set; }

                [NameInMap("lastSchoolName")]
                [Validation(Required=false)]
                public string LastSchoolName { get; set; }

                [NameInMap("married")]
                [Validation(Required=false)]
                public long? Married { get; set; }

                [NameInMap("mbtiType")]
                [Validation(Required=false)]
                public int? MbtiType { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

                [NameInMap("nativePlace")]
                [Validation(Required=false)]
                public string NativePlace { get; set; }

                [NameInMap("nativePlaceCode")]
                [Validation(Required=false)]
                public string NativePlaceCode { get; set; }

                [NameInMap("nowLocation")]
                [Validation(Required=false)]
                public string NowLocation { get; set; }

                [NameInMap("nowLocationCode")]
                [Validation(Required=false)]
                public string NowLocationCode { get; set; }

                [NameInMap("parentIndustry")]
                [Validation(Required=false)]
                public string ParentIndustry { get; set; }

                [NameInMap("parentIndustryCode")]
                [Validation(Required=false)]
                public string ParentIndustryCode { get; set; }

                [NameInMap("personalHonor")]
                [Validation(Required=false)]
                public string PersonalHonor { get; set; }

                [NameInMap("personalUrls")]
                [Validation(Required=false)]
                public List<string> PersonalUrls { get; set; }

                [NameInMap("phoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                [NameInMap("politicalStatus")]
                [Validation(Required=false)]
                public int? PoliticalStatus { get; set; }

                [NameInMap("qq")]
                [Validation(Required=false)]
                public string Qq { get; set; }

                [NameInMap("realAvatar")]
                [Validation(Required=false)]
                public int? RealAvatar { get; set; }

                [NameInMap("selfEvaluation")]
                [Validation(Required=false)]
                public string SelfEvaluation { get; set; }

                [NameInMap("sex")]
                [Validation(Required=false)]
                public int? Sex { get; set; }

                [NameInMap("skillSummary")]
                [Validation(Required=false)]
                public string SkillSummary { get; set; }

                [NameInMap("stateCode")]
                [Validation(Required=false)]
                public string StateCode { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("virtualPhoneNum")]
                [Validation(Required=false)]
                public string VirtualPhoneNum { get; set; }

                [NameInMap("weChat")]
                [Validation(Required=false)]
                public string WeChat { get; set; }

                [NameInMap("weibo")]
                [Validation(Required=false)]
                public string Weibo { get; set; }

                [NameInMap("workingYears")]
                [Validation(Required=false)]
                public int? WorkingYears { get; set; }

            }

            [NameInMap("certificates")]
            [Validation(Required=false)]
            public List<CreateResumeRequestResumeDataVOCertificates> Certificates { get; set; }
            public class CreateResumeRequestResumeDataVOCertificates : TeaModel {
                [NameInMap("certificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

                [NameInMap("certificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                [NameInMap("crantTime")]
                [Validation(Required=false)]
                public string CrantTime { get; set; }

            }

            [NameInMap("jobExpects")]
            [Validation(Required=false)]
            public List<CreateResumeRequestResumeDataVOJobExpects> JobExpects { get; set; }
            public class CreateResumeRequestResumeDataVOJobExpects : TeaModel {
                [NameInMap("cityList")]
                [Validation(Required=false)]
                public List<CreateResumeRequestResumeDataVOJobExpectsCityList> CityList { get; set; }
                public class CreateResumeRequestResumeDataVOJobExpectsCityList : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("industryList")]
                [Validation(Required=false)]
                public List<CreateResumeRequestResumeDataVOJobExpectsIndustryList> IndustryList { get; set; }
                public class CreateResumeRequestResumeDataVOJobExpectsIndustryList : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("jobList")]
                [Validation(Required=false)]
                public List<CreateResumeRequestResumeDataVOJobExpectsJobList> JobList { get; set; }
                public class CreateResumeRequestResumeDataVOJobExpectsJobList : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("jobNature")]
                [Validation(Required=false)]
                public string JobNature { get; set; }

                [NameInMap("maxSalary")]
                [Validation(Required=false)]
                public string MaxSalary { get; set; }

                [NameInMap("minSalary")]
                [Validation(Required=false)]
                public string MinSalary { get; set; }

                [NameInMap("otherCityList")]
                [Validation(Required=false)]
                public List<CreateResumeRequestResumeDataVOJobExpectsOtherCityList> OtherCityList { get; set; }
                public class CreateResumeRequestResumeDataVOJobExpectsOtherCityList : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("salaryDesc")]
                [Validation(Required=false)]
                public string SalaryDesc { get; set; }

                [NameInMap("salarySettleType")]
                [Validation(Required=false)]
                public string SalarySettleType { get; set; }

                [NameInMap("salaryType")]
                [Validation(Required=false)]
                public string SalaryType { get; set; }

                [NameInMap("salaryYear")]
                [Validation(Required=false)]
                public string SalaryYear { get; set; }

            }

            [NameInMap("personalHonors")]
            [Validation(Required=false)]
            public List<CreateResumeRequestResumeDataVOPersonalHonors> PersonalHonors { get; set; }
            public class CreateResumeRequestResumeDataVOPersonalHonors : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("grantTime")]
                [Validation(Required=false)]
                public string GrantTime { get; set; }

            }

            [NameInMap("projectExperiences")]
            [Validation(Required=false)]
            public List<CreateResumeRequestResumeDataVOProjectExperiences> ProjectExperiences { get; set; }
            public class CreateResumeRequestResumeDataVOProjectExperiences : TeaModel {
                [NameInMap("achievement")]
                [Validation(Required=false)]
                public string Achievement { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("projectUrl")]
                [Validation(Required=false)]
                public string ProjectUrl { get; set; }

                [NameInMap("responsibility")]
                [Validation(Required=false)]
                public string Responsibility { get; set; }

                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                [NameInMap("technology")]
                [Validation(Required=false)]
                public string Technology { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<CreateResumeRequestResumeDataVOTags> Tags { get; set; }
            public class CreateResumeRequestResumeDataVOTags : TeaModel {
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

            }

            [NameInMap("workExperiences")]
            [Validation(Required=false)]
            public List<CreateResumeRequestResumeDataVOWorkExperiences> WorkExperiences { get; set; }
            public class CreateResumeRequestResumeDataVOWorkExperiences : TeaModel {
                [NameInMap("achievement")]
                [Validation(Required=false)]
                public string Achievement { get; set; }

                [NameInMap("companyCode")]
                [Validation(Required=false)]
                public string CompanyCode { get; set; }

                [NameInMap("companyName")]
                [Validation(Required=false)]
                public string CompanyName { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("industry")]
                [Validation(Required=false)]
                public string Industry { get; set; }

                [NameInMap("industryCode")]
                [Validation(Required=false)]
                public string IndustryCode { get; set; }

                [NameInMap("internship")]
                [Validation(Required=false)]
                public bool? Internship { get; set; }

                [NameInMap("jobCode")]
                [Validation(Required=false)]
                public string JobCode { get; set; }

                [NameInMap("jobNature")]
                [Validation(Required=false)]
                public string JobNature { get; set; }

                [NameInMap("jobTitle")]
                [Validation(Required=false)]
                public string JobTitle { get; set; }

                [NameInMap("leader")]
                [Validation(Required=false)]
                public string Leader { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("locationCode")]
                [Validation(Required=false)]
                public string LocationCode { get; set; }

                [NameInMap("parentIndustry")]
                [Validation(Required=false)]
                public string ParentIndustry { get; set; }

                [NameInMap("parentIndustryCode")]
                [Validation(Required=false)]
                public string ParentIndustryCode { get; set; }

                [NameInMap("reasonOfLeaving")]
                [Validation(Required=false)]
                public string ReasonOfLeaving { get; set; }

                [NameInMap("responsibility")]
                [Validation(Required=false)]
                public string Responsibility { get; set; }

                [NameInMap("resumePrivacy")]
                [Validation(Required=false)]
                public CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy ResumePrivacy { get; set; }
                public class CreateResumeRequestResumeDataVOWorkExperiencesResumePrivacy : TeaModel {
                    [NameInMap("shieldedCompany")]
                    [Validation(Required=false)]
                    public bool? ShieldedCompany { get; set; }

                    [NameInMap("shieldedRelatedCompany")]
                    [Validation(Required=false)]
                    public bool? ShieldedRelatedCompany { get; set; }

                }

                [NameInMap("salary")]
                [Validation(Required=false)]
                public string Salary { get; set; }

                [NameInMap("selectedSkillOptions")]
                [Validation(Required=false)]
                public List<string> SelectedSkillOptions { get; set; }

                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                [NameInMap("underlingNumber")]
                [Validation(Required=false)]
                public string UnderlingNumber { get; set; }

            }

        }

        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

        [NameInMap("userIdentify")]
        [Validation(Required=false)]
        public string UserIdentify { get; set; }

    }

}
