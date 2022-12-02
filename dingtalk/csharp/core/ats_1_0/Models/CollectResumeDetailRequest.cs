// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectResumeDetailRequest : TeaModel {
        /// <summary>
        /// 业务标识，目前固定为ddats
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 渠道侧简历标识
        /// </summary>
        [NameInMap("channelOuterId")]
        [Validation(Required=false)]
        public string ChannelOuterId { get; set; }

        /// <summary>
        /// 渠道侧候选人标识。
        /// </summary>
        [NameInMap("channelTalentId")]
        [Validation(Required=false)]
        public string ChannelTalentId { get; set; }

        /// <summary>
        /// 简历投递职位标识
        /// </summary>
        [NameInMap("deliverJobId")]
        [Validation(Required=false)]
        public string DeliverJobId { get; set; }

        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        /// <summary>
        /// 简历详情信息
        /// </summary>
        [NameInMap("resumeData")]
        [Validation(Required=false)]
        public CollectResumeDetailRequestResumeData ResumeData { get; set; }
        public class CollectResumeDetailRequestResumeData : TeaModel {
            /// <summary>
            /// 简历基础信息
            /// </summary>
            [NameInMap("baseInfo")]
            [Validation(Required=false)]
            public CollectResumeDetailRequestResumeDataBaseInfo BaseInfo { get; set; }
            public class CollectResumeDetailRequestResumeDataBaseInfo : TeaModel {
                /// <summary>
                /// 年龄
                /// </summary>
                [NameInMap("age")]
                [Validation(Required=false)]
                public int? Age { get; set; }

                /// <summary>
                /// 头像cdn地址，http链接
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// 初次工作时间
                /// </summary>
                [NameInMap("beginWorkTime")]
                [Validation(Required=false)]
                public string BeginWorkTime { get; set; }

                /// <summary>
                /// 生日
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// 邮箱地址
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// 英文名称
                /// </summary>
                [NameInMap("englishName")]
                [Validation(Required=false)]
                public string EnglishName { get; set; }

                /// <summary>
                /// 毕业时间
                /// </summary>
                [NameInMap("graduateTime")]
                [Validation(Required=false)]
                public string GraduateTime { get; set; }

                /// <summary>
                /// 最高学历
                /// </summary>
                [NameInMap("highestEducation")]
                [Validation(Required=false)]
                public int? HighestEducation { get; set; }

                /// <summary>
                /// 当前工作职位名称
                /// </summary>
                [NameInMap("jobTitle")]
                [Validation(Required=false)]
                public string JobTitle { get; set; }

                /// <summary>
                /// 最高学历毕业院校名称
                /// </summary>
                [NameInMap("lastSchoolName")]
                [Validation(Required=false)]
                public string LastSchoolName { get; set; }

                /// <summary>
                /// 婚姻状况
                /// </summary>
                [NameInMap("married")]
                [Validation(Required=false)]
                public int? Married { get; set; }

                /// <summary>
                /// 名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 籍贯地址
                /// </summary>
                [NameInMap("nativePlace")]
                [Validation(Required=false)]
                public string NativePlace { get; set; }

                /// <summary>
                /// 现居住地址
                /// </summary>
                [NameInMap("nowLocation")]
                [Validation(Required=false)]
                public string NowLocation { get; set; }

                /// <summary>
                /// 个人荣誉
                /// </summary>
                [NameInMap("personalHonor")]
                [Validation(Required=false)]
                public string PersonalHonor { get; set; }

                /// <summary>
                /// 手机号
                /// </summary>
                [NameInMap("phoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                /// <summary>
                /// 政治面貌
                /// </summary>
                [NameInMap("politicalStatus")]
                [Validation(Required=false)]
                public int? PoliticalStatus { get; set; }

                /// <summary>
                /// 自我评价
                /// </summary>
                [NameInMap("selfEvaluation")]
                [Validation(Required=false)]
                public string SelfEvaluation { get; set; }

                /// <summary>
                /// 性别
                /// </summary>
                [NameInMap("sex")]
                [Validation(Required=false)]
                public int? Sex { get; set; }

                /// <summary>
                /// 虚拟手机号
                /// </summary>
                [NameInMap("virtualPhoneNum")]
                [Validation(Required=false)]
                public string VirtualPhoneNum { get; set; }

                /// <summary>
                /// 工作年限
                /// </summary>
                [NameInMap("workingYears")]
                [Validation(Required=false)]
                public int? WorkingYears { get; set; }

            }

            /// <summary>
            /// 证书信息
            /// </summary>
            [NameInMap("certificates")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataCertificates> Certificates { get; set; }
            public class CollectResumeDetailRequestResumeDataCertificates : TeaModel {
                /// <summary>
                /// 证书名称
                /// </summary>
                [NameInMap("certificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                /// <summary>
                /// 证书授予时间
                /// </summary>
                [NameInMap("grantTime")]
                [Validation(Required=false)]
                public string GrantTime { get; set; }

            }

            /// <summary>
            /// 教育经历
            /// </summary>
            [NameInMap("educationExperiences")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataEducationExperiences> EducationExperiences { get; set; }
            public class CollectResumeDetailRequestResumeDataEducationExperiences : TeaModel {
                /// <summary>
                /// 学历
                /// </summary>
                [NameInMap("degree")]
                [Validation(Required=false)]
                public int? Degree { get; set; }

                /// <summary>
                /// 院系
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// 详细描述
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 结束时间
                /// </summary>
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// 专业
                /// </summary>
                [NameInMap("major")]
                [Validation(Required=false)]
                public string Major { get; set; }

                /// <summary>
                /// 学校名称
                /// </summary>
                [NameInMap("schoolName")]
                [Validation(Required=false)]
                public string SchoolName { get; set; }

                /// <summary>
                /// 开始时间
                /// </summary>
                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            /// <summary>
            /// 期望职位信息
            /// </summary>
            [NameInMap("jobExpect")]
            [Validation(Required=false)]
            public CollectResumeDetailRequestResumeDataJobExpect JobExpect { get; set; }
            public class CollectResumeDetailRequestResumeDataJobExpect : TeaModel {
                /// <summary>
                /// 期望职位名称
                /// </summary>
                [NameInMap("jobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// 期望工作地
                /// </summary>
                [NameInMap("locations")]
                [Validation(Required=false)]
                public List<string> Locations { get; set; }

                /// <summary>
                /// 最高期望工资
                /// </summary>
                [NameInMap("maxSalary")]
                [Validation(Required=false)]
                public string MaxSalary { get; set; }

                /// <summary>
                /// 最低期望工资
                /// </summary>
                [NameInMap("minSalary")]
                [Validation(Required=false)]
                public string MinSalary { get; set; }

                /// <summary>
                /// 期望入职时间
                /// </summary>
                [NameInMap("onboardTime")]
                [Validation(Required=false)]
                public string OnboardTime { get; set; }

            }

            /// <summary>
            /// 语言能力
            /// </summary>
            [NameInMap("languageSkill")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataLanguageSkill> LanguageSkill { get; set; }
            public class CollectResumeDetailRequestResumeDataLanguageSkill : TeaModel {
                /// <summary>
                /// 证书名称
                /// </summary>
                [NameInMap("certificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                /// <summary>
                /// 语言名称
                /// </summary>
                [NameInMap("languageName")]
                [Validation(Required=false)]
                public string LanguageName { get; set; }

            }

            /// <summary>
            /// 培训经历
            /// </summary>
            [NameInMap("trainingExperiences")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataTrainingExperiences> TrainingExperiences { get; set; }
            public class CollectResumeDetailRequestResumeDataTrainingExperiences : TeaModel {
                /// <summary>
                /// 详细内容描述
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 结束时间
                /// </summary>
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// 培训机构名称
                /// </summary>
                [NameInMap("institutionName")]
                [Validation(Required=false)]
                public string InstitutionName { get; set; }

                /// <summary>
                /// 培训地点
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// 培训名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 开始时间
                /// </summary>
                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            /// <summary>
            /// 工作经历
            /// </summary>
            [NameInMap("workExperiences")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataWorkExperiences> WorkExperiences { get; set; }
            public class CollectResumeDetailRequestResumeDataWorkExperiences : TeaModel {
                /// <summary>
                /// 公司名称
                /// </summary>
                [NameInMap("companyName")]
                [Validation(Required=false)]
                public string CompanyName { get; set; }

                /// <summary>
                /// 部门
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// 工作详情描述
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// 职位名称
                /// </summary>
                [NameInMap("jobTitle")]
                [Validation(Required=false)]
                public string JobTitle { get; set; }

                /// <summary>
                /// 工作地点
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// 工作职责
                /// </summary>
                [NameInMap("responsibility")]
                [Validation(Required=false)]
                public string Responsibility { get; set; }

                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

        }

    }

}
