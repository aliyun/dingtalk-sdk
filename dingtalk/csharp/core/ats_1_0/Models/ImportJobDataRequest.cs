// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class ImportJobDataRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ImportJobDataRequestBody> Body { get; set; }
        public class ImportJobDataRequestBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public ImportJobDataRequestBodyAddress Address { get; set; }
            public class ImportJobDataRequestBodyAddress : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("cityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("customName")]
                [Validation(Required=false)]
                public string CustomName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("districtCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("provinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("jobNature")]
            [Validation(Required=false)]
            public string JobNature { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("maxSalary")]
            [Validation(Required=false)]
            public long? MaxSalary { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("minSalary")]
            [Validation(Required=false)]
            public long? MinSalary { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("requiredEdu")]
            [Validation(Required=false)]
            public int? RequiredEdu { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
