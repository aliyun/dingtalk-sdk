// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetChildrenResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetChildrenResponseBodyResult> Result { get; set; }
        public class GetChildrenResponseBodyResult : TeaModel {
            [NameInMap("bindStudents")]
            [Validation(Required=false)]
            public List<GetChildrenResponseBodyResultBindStudents> BindStudents { get; set; }
            public class GetChildrenResponseBodyResultBindStudents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("gradeLevel")]
                [Validation(Required=false)]
                public int? GradeLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dinge066bea21c63b79b35c2f4657eb6378f</para>
                /// </summary>
                [NameInMap("identityId")]
                [Validation(Required=false)]
                public string IdentityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>primary_school</para>
                /// </summary>
                [NameInMap("periodCode")]
                [Validation(Required=false)]
                public string PeriodCode { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("city")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>西湖区</para>
            /// </summary>
            [NameInMap("district")]
            [Validation(Required=false)]
            public string District { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("gradeLevel")]
            [Validation(Required=false)]
            public int? GradeLevel { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>primary_school</para>
            /// </summary>
            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浙江省</para>
            /// </summary>
            [NameInMap("province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330106</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
