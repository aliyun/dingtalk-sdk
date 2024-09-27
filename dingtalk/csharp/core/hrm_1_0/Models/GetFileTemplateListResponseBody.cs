// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetFileTemplateListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFileTemplateListResponseBodyResult Result { get; set; }
        public class GetFileTemplateListResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<GetFileTemplateListResponseBodyResultData> Data { get; set; }
            public class GetFileTemplateListResponseBodyResultData : TeaModel {
                [NameInMap("attachmentList")]
                [Validation(Required=false)]
                public List<GetFileTemplateListResponseBodyResultDataAttachmentList> AttachmentList { get; set; }
                public class GetFileTemplateListResponseBodyResultDataAttachmentList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>简历附件</para>
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>attachment_profile</para>
                    /// </summary>
                    [NameInMap("fieldCode")]
                    [Validation(Required=false)]
                    public string FieldCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>简历附件</para>
                    /// </summary>
                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DDAttachmentField</para>
                    /// </summary>
                    [NameInMap("fieldType")]
                    [Validation(Required=false)]
                    public string FieldType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>attachment</para>
                    /// </summary>
                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("signRequired")]
                    [Validation(Required=false)]
                    public bool? SignRequired { get; set; }

                    [NameInMap("userCustomField")]
                    [Validation(Required=false)]
                    public bool? UserCustomField { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ding57935b18bfd13e9735c2f4657eb6378f</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("fieldList")]
                [Validation(Required=false)]
                public List<GetFileTemplateListResponseBodyResultDataFieldList> FieldList { get; set; }
                public class GetFileTemplateListResponseBodyResultDataFieldList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>真实姓名字段</para>
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>esign_name</para>
                    /// </summary>
                    [NameInMap("fieldCode")]
                    [Validation(Required=false)]
                    public string FieldCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>真实姓名</para>
                    /// </summary>
                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TextField</para>
                    /// </summary>
                    [NameInMap("fieldType")]
                    [Validation(Required=false)]
                    public string FieldType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>baseInfo</para>
                    /// </summary>
                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("signRequired")]
                    [Validation(Required=false)]
                    public bool? SignRequired { get; set; }

                    [NameInMap("userCustomField")]
                    [Validation(Required=false)]
                    public bool? UserCustomField { get; set; }

                }

                [NameInMap("groupList")]
                [Validation(Required=false)]
                public List<GetFileTemplateListResponseBodyResultDataGroupList> GroupList { get; set; }
                public class GetFileTemplateListResponseBodyResultDataGroupList : TeaModel {
                    [NameInMap("detailFlag")]
                    [Validation(Required=false)]
                    public bool? DetailFlag { get; set; }

                    [NameInMap("fieldList")]
                    [Validation(Required=false)]
                    public List<GetFileTemplateListResponseBodyResultDataGroupListFieldList> FieldList { get; set; }
                    public class GetFileTemplateListResponseBodyResultDataGroupListFieldList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>家庭成员明细分组</para>
                        /// </summary>
                        [NameInMap("desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>family.member_name</para>
                        /// </summary>
                        [NameInMap("fieldCode")]
                        [Validation(Required=false)]
                        public string FieldCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>成员姓名</para>
                        /// </summary>
                        [NameInMap("fieldName")]
                        [Validation(Required=false)]
                        public string FieldName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TextField</para>
                        /// </summary>
                        [NameInMap("fieldType")]
                        [Validation(Required=false)]
                        public string FieldType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>family</para>
                        /// </summary>
                        [NameInMap("groupId")]
                        [Validation(Required=false)]
                        public string GroupId { get; set; }

                        [NameInMap("signRequired")]
                        [Validation(Required=false)]
                        public bool? SignRequired { get; set; }

                        [NameInMap("userCustomField")]
                        [Validation(Required=false)]
                        public bool? UserCustomField { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>family</para>
                    /// </summary>
                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>家庭成员</para>
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f3ed5402e3024febaed773b3ac19feb3</para>
                /// </summary>
                [NameInMap("templateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("templateInstName")]
                [Validation(Required=false)]
                public string TemplateInstName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>劳动合同模板</para>
                /// </summary>
                [NameInMap("templateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("templateSignStatus")]
                [Validation(Required=false)]
                public int? TemplateSignStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("templateStatus")]
                [Validation(Required=false)]
                public int? TemplateStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CONTRACT</para>
                /// </summary>
                [NameInMap("templateType")]
                [Validation(Required=false)]
                public string TemplateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>合同模板</para>
                /// </summary>
                [NameInMap("templateTypeName")]
                [Validation(Required=false)]
                public string TemplateTypeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
