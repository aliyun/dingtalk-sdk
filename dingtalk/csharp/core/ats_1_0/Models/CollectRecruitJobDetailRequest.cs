// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectRecruitJobDetailRequest : TeaModel {
        /// <summary>
        /// 业务标识，目前固定为ddats
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务标识，目前固定为ddats
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("jonInfo")]
        [Validation(Required=false)]
        public CollectRecruitJobDetailRequestJonInfo JonInfo { get; set; }
        public class CollectRecruitJobDetailRequestJonInfo : TeaModel {
            /// <summary>
            /// 地址信息
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public CollectRecruitJobDetailRequestJonInfoAddress Address { get; set; }
            public class CollectRecruitJobDetailRequestJonInfoAddress : TeaModel {
                /// <summary>
                /// 城市编码
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// 位置详情描述
                /// </summary>
                [NameInMap("detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// 区县编码
                /// </summary>
                [NameInMap("districtCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                /// <summary>
                /// 经度（高德地图选点）
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// 纬度（高德地图选点）
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                /// <summary>
                /// 位置名称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 省份编码
                /// </summary>
                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

            }

            /// <summary>
            /// 职位分类编码
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// 职位描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// 全职信息
            /// </summary>
            [NameInMap("fullTimeInfo")]
            [Validation(Required=false)]
            public CollectRecruitJobDetailRequestJonInfoFullTimeInfo FullTimeInfo { get; set; }
            public class CollectRecruitJobDetailRequestJonInfoFullTimeInfo : TeaModel {
                /// <summary>
                /// 工作经验要求最高年限
                /// </summary>
                [NameInMap("maxJobExperience")]
                [Validation(Required=false)]
                public string MaxJobExperience { get; set; }

                /// <summary>
                /// 工作经验要求最低年限
                /// </summary>
                [NameInMap("minJobExperience")]
                [Validation(Required=false)]
                public string MinJobExperience { get; set; }

                /// <summary>
                /// 薪资发放月数
                /// </summary>
                [NameInMap("salaryMonth")]
                [Validation(Required=false)]
                public string SalaryMonth { get; set; }

            }

            /// <summary>
            /// 招聘人数
            /// </summary>
            [NameInMap("headCount")]
            [Validation(Required=false)]
            public string HeadCount { get; set; }

            /// <summary>
            /// 职位性质
            /// </summary>
            [NameInMap("jobNature")]
            [Validation(Required=false)]
            public string JobNature { get; set; }

            /// <summary>
            /// 职位标签，字符串列表
            /// </summary>
            [NameInMap("jobTags")]
            [Validation(Required=false)]
            public List<string> JobTags { get; set; }

            /// <summary>
            /// 最高薪资
            /// </summary>
            [NameInMap("maxSalary")]
            [Validation(Required=false)]
            public string MaxSalary { get; set; }

            /// <summary>
            /// 最低薪资
            /// </summary>
            [NameInMap("minSalary")]
            [Validation(Required=false)]
            public string MinSalary { get; set; }

            /// <summary>
            /// 职位名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 渠道职位ID
            /// </summary>
            [NameInMap("outJobId")]
            [Validation(Required=false)]
            public string OutJobId { get; set; }

            /// <summary>
            /// 兼职信息
            /// </summary>
            [NameInMap("partTimeInfo")]
            [Validation(Required=false)]
            public CollectRecruitJobDetailRequestJonInfoPartTimeInfo PartTimeInfo { get; set; }
            public class CollectRecruitJobDetailRequestJonInfoPartTimeInfo : TeaModel {
                /// <summary>
                /// 联系电话
                /// </summary>
                [NameInMap("contactNumber")]
                [Validation(Required=false)]
                public string ContactNumber { get; set; }

                /// <summary>
                /// 薪资发放周期
                /// </summary>
                [NameInMap("salaryPeriod")]
                [Validation(Required=false)]
                public string SalaryPeriod { get; set; }

                /// <summary>
                /// 薪资结算类型
                /// </summary>
                [NameInMap("settleType")]
                [Validation(Required=false)]
                public string SettleType { get; set; }

                /// <summary>
                /// 是否指定工作日期
                /// </summary>
                [NameInMap("specifyWorkDate")]
                [Validation(Required=false)]
                public string SpecifyWorkDate { get; set; }

                /// <summary>
                /// 是否指定工作时间
                /// </summary>
                [NameInMap("specifyWorkTime")]
                [Validation(Required=false)]
                public string SpecifyWorkTime { get; set; }

                /// <summary>
                /// 工作开始时间
                /// </summary>
                [NameInMap("workBeginTimeMin")]
                [Validation(Required=false)]
                public string WorkBeginTimeMin { get; set; }

                /// <summary>
                /// 工作日期类型
                /// </summary>
                [NameInMap("workDateType")]
                [Validation(Required=false)]
                public string WorkDateType { get; set; }

                /// <summary>
                /// 工作结束日期
                /// </summary>
                [NameInMap("workEndDate")]
                [Validation(Required=false)]
                public string WorkEndDate { get; set; }

                /// <summary>
                /// 工作结束时间
                /// </summary>
                [NameInMap("workEndTimeMin")]
                [Validation(Required=false)]
                public string WorkEndTimeMin { get; set; }

                /// <summary>
                /// 工作开始日期
                /// </summary>
                [NameInMap("workStartDate")]
                [Validation(Required=false)]
                public string WorkStartDate { get; set; }

            }

            /// <summary>
            /// 学历要求
            /// </summary>
            [NameInMap("requiredEdu")]
            [Validation(Required=false)]
            public string RequiredEdu { get; set; }

        }

        /// <summary>
        /// 渠道侧外部企业唯一ID
        /// </summary>
        [NameInMap("outCorpId")]
        [Validation(Required=false)]
        public string OutCorpId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [NameInMap("outCorpName")]
        [Validation(Required=false)]
        public string OutCorpName { get; set; }

        /// <summary>
        /// 招聘人信息
        /// </summary>
        [NameInMap("recruitUserInfo")]
        [Validation(Required=false)]
        public CollectRecruitJobDetailRequestRecruitUserInfo RecruitUserInfo { get; set; }
        public class CollectRecruitJobDetailRequestRecruitUserInfo : TeaModel {
            /// <summary>
            /// 额外信息
            /// </summary>
            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// 招聘员工唯一ID
            /// </summary>
            [NameInMap("outUserId")]
            [Validation(Required=false)]
            public string OutUserId { get; set; }

            /// <summary>
            /// 招聘员工手机号码
            /// </summary>
            [NameInMap("userMobile")]
            [Validation(Required=false)]
            public string UserMobile { get; set; }

            /// <summary>
            /// 招聘员工姓名
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// 来源
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 数据源更新时间
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
