// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class ImportJobDataRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ImportJobDataRequestBody> Body { get; set; }
        public class ImportJobDataRequestBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public ImportJobDataRequestBodyAddress Address { get; set; }
            public class ImportJobDataRequestBodyAddress : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("customName")]
                [Validation(Required=false)]
                public string CustomName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("districtCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("experience")]
            [Validation(Required=false)]
            public string Experience { get; set; }

            [NameInMap("fullTimeExt")]
            [Validation(Required=false)]
            public ImportJobDataRequestBodyFullTimeExt FullTimeExt { get; set; }
            public class ImportJobDataRequestBodyFullTimeExt : TeaModel {
                [NameInMap("salaryMonth")]
                [Validation(Required=false)]
                public int? SalaryMonth { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("jobNature")]
            [Validation(Required=false)]
            public string JobNature { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("maxSalary")]
            [Validation(Required=false)]
            public long? MaxSalary { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("minSalary")]
            [Validation(Required=false)]
            public long? MinSalary { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("requiredEdu")]
            [Validation(Required=false)]
            public int? RequiredEdu { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
