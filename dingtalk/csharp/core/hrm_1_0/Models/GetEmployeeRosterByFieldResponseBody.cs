// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetEmployeeRosterByFieldResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetEmployeeRosterByFieldResponseBodyResult> Result { get; set; }
        public class GetEmployeeRosterByFieldResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding20a11xxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("fieldDataList")]
            [Validation(Required=false)]
            public List<GetEmployeeRosterByFieldResponseBodyResultFieldDataList> FieldDataList { get; set; }
            public class GetEmployeeRosterByFieldResponseBodyResultFieldDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>sys01-employeeStatus</para>
                /// </summary>
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>员工状态</para>
                /// </summary>
                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("fieldValueList")]
                [Validation(Required=false)]
                public List<GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList> FieldValueList { get; set; }
                public class GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("itemIndex")]
                    [Validation(Required=false)]
                    public int? ItemIndex { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>正式</para>
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sys01</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

            }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>042519</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
