// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetInstancesByIdListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetInstancesByIdListResponseBodyResult> Result { get; set; }
        public class GetInstancesByIdListResponseBodyResult : TeaModel {
            [NameInMap("actionExecutor")]
            [Validation(Required=false)]
            public List<GetInstancesByIdListResponseBodyResultActionExecutor> ActionExecutor { get; set; }
            public class GetInstancesByIdListResponseBodyResultActionExecutor : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>开发部</para>
                /// </summary>
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesByIdListResponseBodyResultActionExecutorName Name { get; set; }
                public class GetInstancesByIdListResponseBodyResultActionExecutorName : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZhangSan</para>
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i18n</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agree</para>
            /// </summary>
            [NameInMap("approvedResult")]
            [Validation(Required=false)]
            public string ApprovedResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;numberField_jcr0069o&quot;:1,&quot;multiSelectField_jcr0069s&quot;:[&quot;选项三&quot;,&quot;选项二&quot;],&quot;textareaField_jcr0069n&quot;:&quot;duohang&quot;,&quot;employeeField_jcr0069x&quot;:[&quot;xxxx&quot;],&quot;departmentField_jcr0069z&quot;:&quot;信息xxx平台&quot;,&quot;cascadeDate_jcr0069u&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;cascadeSelectField_jcr006a0&quot;:[&quot;part&quot;,&quot;part_b&quot;],&quot;tableField_jcr006a1&quot;:[{&quot;departmentField_jcr006ad&quot;:&quot;信息xxx&quot;,&quot;cascadeDate_jcr006aa&quot;:[&quot;1514736000000&quot;,&quot;1517328000000&quot;],&quot;selectField_jcr006a6&quot;:&quot;选项三&quot;,&quot;citySelectField_jcr006ac&quot;:[&quot;天津&quot;,&quot;天津市&quot;,&quot;河东区&quot;],&quot;radioField_jcr006a5&quot;:&quot;选项二&quot;,&quot;employeeField_jcr006ab&quot;:[&quot;yyyyy&quot;,&quot;xxxxxx&quot;],&quot;dateField_jcr006a9&quot;:1517328000000,&quot;textField_jcr006a2&quot;:&quot;明细下单行&quot;,&quot;textareaField_jcr006a3&quot;:&quot;明细下多行&quot;,&quot;cascadeSelectField_jcr006ae&quot;:[&quot;product&quot;,&quot;product_a&quot;],&quot;numberField_jcr006a4&quot;:2,&quot;checkboxField_jcr006a7&quot;:[&quot;选项一&quot;,&quot;选项三&quot;,&quot;选项二&quot;],&quot;multiSelectField_jcr006a8&quot;:[&quot;选项一&quot;,&quot;选项三&quot;,&quot;选项二&quot;]}],&quot;selectField_jcr0069q&quot;:&quot;选项一&quot;,&quot;citySelectField_jcr0069y&quot;:[&quot;北京&quot;,&quot;北京市&quot;,&quot;东城区&quot;],&quot;checkboxField_jcr0069r&quot;:[&quot;选项三&quot;,&quot;选项二&quot;],&quot;textField_jcr0069m&quot;:&quot;danhang&quot;,&quot;radioField_jcr0069p&quot;:&quot;选项一&quot;,&quot;dateField_jcr0069t&quot;:1516636800000}</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public Dictionary<string, object> Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3</para>
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("instanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            [NameInMap("originator")]
            [Validation(Required=false)]
            public GetInstancesByIdListResponseBodyResultOriginator Originator { get; set; }
            public class GetInstancesByIdListResponseBodyResultOriginator : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>开发部</para>
                /// </summary>
                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public GetInstancesByIdListResponseBodyResultOriginatorName Name { get; set; }
                public class GetInstancesByIdListResponseBodyResultOriginatorName : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("nameInChinese")]
                    [Validation(Required=false)]
                    public string NameInChinese { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ZhangSan</para>
                    /// </summary>
                    [NameInMap("nameInEnglish")]
                    [Validation(Required=false)]
                    public string NameInEnglish { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i18n</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TPROC--EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ4</para>
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f30233fb-72e1-4af4-8cb8-c7e0ea9ee530</para>
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx 发起的流程</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
