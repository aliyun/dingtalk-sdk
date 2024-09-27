// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectResumeDetailRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ddats</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>liepin</para>
        /// </summary>
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>resumexxxxxxxxxx</para>
        /// </summary>
        [NameInMap("channelOuterId")]
        [Validation(Required=false)]
        public string ChannelOuterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("channelTalentId")]
        [Validation(Required=false)]
        public string ChannelTalentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jobId8fc0d56a605d495ea0214af7axxxxxxx</para>
        /// </summary>
        [NameInMap("deliverJobId")]
        [Validation(Required=false)]
        public string DeliverJobId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2701606624233xxxxx</para>
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http:<a href="http://www.xxx.com">www.xxx.com</a></para>
        /// </summary>
        [NameInMap("resumeChannelUrl")]
        [Validation(Required=false)]
        public string ResumeChannelUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resumeData")]
        [Validation(Required=false)]
        public CollectResumeDetailRequestResumeData ResumeData { get; set; }
        public class CollectResumeDetailRequestResumeData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("baseInfo")]
            [Validation(Required=false)]
            public CollectResumeDetailRequestResumeDataBaseInfo BaseInfo { get; set; }
            public class CollectResumeDetailRequestResumeDataBaseInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("age")]
                [Validation(Required=false)]
                public int? Age { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.xxxx.com">http://www.xxxx.com</a></para>
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("beginWorkTime")]
                [Validation(Required=false)]
                public string BeginWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:xxxxxxx@alibaba-inc.com">xxxxxxx@alibaba-inc.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Jason</para>
                /// </summary>
                [NameInMap("englishName")]
                [Validation(Required=false)]
                public string EnglishName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("graduateTime")]
                [Validation(Required=false)]
                public string GraduateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("highestEducation")]
                [Validation(Required=false)]
                public int? HighestEducation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>java开发工程师</para>
                /// </summary>
                [NameInMap("jobTitle")]
                [Validation(Required=false)]
                public string JobTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>清华大学</para>
                /// </summary>
                [NameInMap("lastSchoolName")]
                [Validation(Required=false)]
                public string LastSchoolName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("married")]
                [Validation(Required=false)]
                public int? Married { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>孙先生</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>浙江省杭州市余杭区仓前街道</para>
                /// </summary>
                [NameInMap("nativePlace")]
                [Validation(Required=false)]
                public string NativePlace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>浙江省杭州市余杭区仓前街道欧美金融城</para>
                /// </summary>
                [NameInMap("nowLocation")]
                [Validation(Required=false)]
                public string NowLocation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>曾获得xxx比赛xxx奖项</para>
                /// </summary>
                [NameInMap("personalHonor")]
                [Validation(Required=false)]
                public string PersonalHonor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>187xxxxxxxx</para>
                /// </summary>
                [NameInMap("phoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("politicalStatus")]
                [Validation(Required=false)]
                public int? PoliticalStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>沟通能力强......</para>
                /// </summary>
                [NameInMap("selfEvaluation")]
                [Validation(Required=false)]
                public string SelfEvaluation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sex")]
                [Validation(Required=false)]
                public int? Sex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>187xxxxxxxx</para>
                /// </summary>
                [NameInMap("virtualPhoneNum")]
                [Validation(Required=false)]
                public string VirtualPhoneNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("workingYears")]
                [Validation(Required=false)]
                public int? WorkingYears { get; set; }

            }

            [NameInMap("certificates")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataCertificates> Certificates { get; set; }
            public class CollectResumeDetailRequestResumeDataCertificates : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>高级技工证书</para>
                /// </summary>
                [NameInMap("certificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("grantTime")]
                [Validation(Required=false)]
                public string GrantTime { get; set; }

            }

            [NameInMap("educationExperiences")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataEducationExperiences> EducationExperiences { get; set; }
            public class CollectResumeDetailRequestResumeDataEducationExperiences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("degree")]
                [Validation(Required=false)]
                public int? Degree { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>计算机学院</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>在校期间.......</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>计算机科学与技术</para>
                /// </summary>
                [NameInMap("major")]
                [Validation(Required=false)]
                public string Major { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>清华大学</para>
                /// </summary>
                [NameInMap("schoolName")]
                [Validation(Required=false)]
                public string SchoolName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            [NameInMap("jobExpect")]
            [Validation(Required=false)]
            public CollectResumeDetailRequestResumeDataJobExpect JobExpect { get; set; }
            public class CollectResumeDetailRequestResumeDataJobExpect : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Java开发工程师</para>
                /// </summary>
                [NameInMap("jobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                [NameInMap("locations")]
                [Validation(Required=false)]
                public List<string> Locations { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8000</para>
                /// </summary>
                [NameInMap("maxSalary")]
                [Validation(Required=false)]
                public string MaxSalary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("minSalary")]
                [Validation(Required=false)]
                public string MinSalary { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("onboardTime")]
                [Validation(Required=false)]
                public string OnboardTime { get; set; }

            }

            [NameInMap("languageSkill")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataLanguageSkill> LanguageSkill { get; set; }
            public class CollectResumeDetailRequestResumeDataLanguageSkill : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>大学英语六级</para>
                /// </summary>
                [NameInMap("certificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>英语</para>
                /// </summary>
                [NameInMap("languageName")]
                [Validation(Required=false)]
                public string LanguageName { get; set; }

            }

            [NameInMap("trainingExperiences")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataTrainingExperiences> TrainingExperiences { get; set; }
            public class CollectResumeDetailRequestResumeDataTrainingExperiences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>培训期间，学习了xxxx技能，获取xxxx证书。</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>新东方挖掘机学校</para>
                /// </summary>
                [NameInMap("institutionName")]
                [Validation(Required=false)]
                public string InstitutionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>浙江省杭州市余杭区</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>挖掘机专业技能培训</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

            [NameInMap("workExperiences")]
            [Validation(Required=false)]
            public List<CollectResumeDetailRequestResumeDataWorkExperiences> WorkExperiences { get; set; }
            public class CollectResumeDetailRequestResumeDataWorkExperiences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>钉钉（中国）信息技术有限公司</para>
                /// </summary>
                [NameInMap("companyName")]
                [Validation(Required=false)]
                public string CompanyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>智能人事</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>工作期间负责......取得了......成果</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Java开发工程师</para>
                /// </summary>
                [NameInMap("jobTitle")]
                [Validation(Required=false)]
                public string JobTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>负责......</para>
                /// </summary>
                [NameInMap("responsibility")]
                [Validation(Required=false)]
                public string Responsibility { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd</para>
                /// </summary>
                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

        }

        [NameInMap("resumeFile")]
        [Validation(Required=false)]
        public CollectResumeDetailRequestResumeFile ResumeFile { get; set; }
        public class CollectResumeDetailRequestResumeFile : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>http:<a href="http://www.xxx.com">www.xxx.com</a></para>
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

        }

    }

}
