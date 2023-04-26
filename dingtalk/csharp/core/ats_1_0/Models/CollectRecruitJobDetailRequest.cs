// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectRecruitJobDetailRequest : TeaModel {
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

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
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                [NameInMap("districtCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                [NameInMap("latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                [NameInMap("longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

            }

            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

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
                [NameInMap("maxJobExperience")]
                [Validation(Required=false)]
                public string MaxJobExperience { get; set; }

                [NameInMap("minJobExperience")]
                [Validation(Required=false)]
                public string MinJobExperience { get; set; }

                [NameInMap("salaryMonth")]
                [Validation(Required=false)]
                public string SalaryMonth { get; set; }

            }

            [NameInMap("headCount")]
            [Validation(Required=false)]
            public string HeadCount { get; set; }

            [NameInMap("jobNature")]
            [Validation(Required=false)]
            public string JobNature { get; set; }

            [NameInMap("jobTags")]
            [Validation(Required=false)]
            public List<string> JobTags { get; set; }

            [NameInMap("maxSalary")]
            [Validation(Required=false)]
            public string MaxSalary { get; set; }

            [NameInMap("minSalary")]
            [Validation(Required=false)]
            public string MinSalary { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("outJobId")]
            [Validation(Required=false)]
            public string OutJobId { get; set; }

            [NameInMap("partTimeInfo")]
            [Validation(Required=false)]
            public CollectRecruitJobDetailRequestJobInfoPartTimeInfo PartTimeInfo { get; set; }
            public class CollectRecruitJobDetailRequestJobInfoPartTimeInfo : TeaModel {
                [NameInMap("contactNumber")]
                [Validation(Required=false)]
                public string ContactNumber { get; set; }

                [NameInMap("salaryPeriod")]
                [Validation(Required=false)]
                public string SalaryPeriod { get; set; }

                [NameInMap("settleType")]
                [Validation(Required=false)]
                public string SettleType { get; set; }

                [NameInMap("specifyWorkDate")]
                [Validation(Required=false)]
                public string SpecifyWorkDate { get; set; }

                [NameInMap("specifyWorkTime")]
                [Validation(Required=false)]
                public string SpecifyWorkTime { get; set; }

                [NameInMap("workBeginTimeMin")]
                [Validation(Required=false)]
                public string WorkBeginTimeMin { get; set; }

                [NameInMap("workDateType")]
                [Validation(Required=false)]
                public string WorkDateType { get; set; }

                [NameInMap("workEndDate")]
                [Validation(Required=false)]
                public string WorkEndDate { get; set; }

                [NameInMap("workEndTimeMin")]
                [Validation(Required=false)]
                public string WorkEndTimeMin { get; set; }

                [NameInMap("workStartDate")]
                [Validation(Required=false)]
                public string WorkStartDate { get; set; }

            }

            [NameInMap("requiredEdu")]
            [Validation(Required=false)]
            public string RequiredEdu { get; set; }

        }

        [NameInMap("outCorpId")]
        [Validation(Required=false)]
        public string OutCorpId { get; set; }

        [NameInMap("outCorpName")]
        [Validation(Required=false)]
        public string OutCorpName { get; set; }

        [NameInMap("recruitUserInfo")]
        [Validation(Required=false)]
        public CollectRecruitJobDetailRequestRecruitUserInfo RecruitUserInfo { get; set; }
        public class CollectRecruitJobDetailRequestRecruitUserInfo : TeaModel {
            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("outUserId")]
            [Validation(Required=false)]
            public string OutUserId { get; set; }

            [NameInMap("userMobile")]
            [Validation(Required=false)]
            public string UserMobile { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
