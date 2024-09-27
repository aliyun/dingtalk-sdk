// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectRecruitJobDetailRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ddats</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhilian</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("jobInfo")]
        [Validation(Required=false)]
        public CollectRecruitJobDetailRequestJobInfo JobInfo { get; set; }
        public class CollectRecruitJobDetailRequestJobInfo : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public CollectRecruitJobDetailRequestJobInfoAddress Address { get; set; }
            public class CollectRecruitJobDetailRequestJobInfoAddress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>310000</para>
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文一西路999号</para>
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>311000</para>
                /// </summary>
                [NameInMap("districtCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>89.54613</para>
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>128.45613</para>
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>总部大楼</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300000</para>
                /// </summary>
                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>C10001</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>园艺师职位描述</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("fullTimeInfo")]
            [Validation(Required=false)]
            public CollectRecruitJobDetailRequestJobInfoFullTimeInfo FullTimeInfo { get; set; }
            public class CollectRecruitJobDetailRequestJobInfoFullTimeInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("maxJobExperience")]
                [Validation(Required=false)]
                public string MaxJobExperience { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("minJobExperience")]
                [Validation(Required=false)]
                public string MinJobExperience { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("salaryMonth")]
                [Validation(Required=false)]
                public string SalaryMonth { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("headCount")]
            [Validation(Required=false)]
            public string HeadCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FULL-TIME</para>
            /// </summary>
            [NameInMap("jobNature")]
            [Validation(Required=false)]
            public string JobNature { get; set; }

            [NameInMap("jobTags")]
            [Validation(Required=false)]
            public List<string> JobTags { get; set; }

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
            /// <para>园艺师</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jobIdxxxxxxx</para>
            /// </summary>
            [NameInMap("outJobId")]
            [Validation(Required=false)]
            public string OutJobId { get; set; }

            [NameInMap("partTimeInfo")]
            [Validation(Required=false)]
            public CollectRecruitJobDetailRequestJobInfoPartTimeInfo PartTimeInfo { get; set; }
            public class CollectRecruitJobDetailRequestJobInfoPartTimeInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>158****8718</para>
                /// </summary>
                [NameInMap("contactNumber")]
                [Validation(Required=false)]
                public string ContactNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MONTH</para>
                /// </summary>
                [NameInMap("salaryPeriod")]
                [Validation(Required=false)]
                public string SalaryPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MONTH</para>
                /// </summary>
                [NameInMap("settleType")]
                [Validation(Required=false)]
                public string SettleType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>N</para>
                /// </summary>
                [NameInMap("specifyWorkDate")]
                [Validation(Required=false)]
                public string SpecifyWorkDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>N</para>
                /// </summary>
                [NameInMap("specifyWorkTime")]
                [Validation(Required=false)]
                public string SpecifyWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>480</para>
                /// </summary>
                [NameInMap("workBeginTimeMin")]
                [Validation(Required=false)]
                public string WorkBeginTimeMin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>WORKDAY</para>
                /// </summary>
                [NameInMap("workDateType")]
                [Validation(Required=false)]
                public string WorkDateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-02-18</para>
                /// </summary>
                [NameInMap("workEndDate")]
                [Validation(Required=false)]
                public string WorkEndDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("workEndTimeMin")]
                [Validation(Required=false)]
                public string WorkEndTimeMin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-02-18</para>
                /// </summary>
                [NameInMap("workStartDate")]
                [Validation(Required=false)]
                public string WorkStartDate { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>高中</para>
            /// </summary>
            [NameInMap("requiredEdu")]
            [Validation(Required=false)]
            public string RequiredEdu { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>corpxxxxxxxxx</para>
        /// </summary>
        [NameInMap("outCorpId")]
        [Validation(Required=false)]
        public string OutCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>小莫科技有限公司</para>
        /// </summary>
        [NameInMap("outCorpName")]
        [Validation(Required=false)]
        public string OutCorpName { get; set; }

        [NameInMap("recruitUserInfo")]
        [Validation(Required=false)]
        public CollectRecruitJobDetailRequestRecruitUserInfo RecruitUserInfo { get; set; }
        public class CollectRecruitJobDetailRequestRecruitUserInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;sex&quot;:&quot;male&quot;}</para>
            /// </summary>
            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>userxxxxx</para>
            /// </summary>
            [NameInMap("outUserId")]
            [Validation(Required=false)]
            public string OutUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>158****8717</para>
            /// </summary>
            [NameInMap("userMobile")]
            [Validation(Required=false)]
            public string UserMobile { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>陈*</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BOSS</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1677465956008</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
