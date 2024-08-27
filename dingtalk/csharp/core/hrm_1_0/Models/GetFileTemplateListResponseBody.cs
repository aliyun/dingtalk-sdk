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
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("fieldCode")]
                    [Validation(Required=false)]
                    public string FieldCode { get; set; }

                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    [NameInMap("fieldType")]
                    [Validation(Required=false)]
                    public string FieldType { get; set; }

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

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("fieldList")]
                [Validation(Required=false)]
                public List<GetFileTemplateListResponseBodyResultDataFieldList> FieldList { get; set; }
                public class GetFileTemplateListResponseBodyResultDataFieldList : TeaModel {
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("fieldCode")]
                    [Validation(Required=false)]
                    public string FieldCode { get; set; }

                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    [NameInMap("fieldType")]
                    [Validation(Required=false)]
                    public string FieldType { get; set; }

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
                        [NameInMap("desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        [NameInMap("fieldCode")]
                        [Validation(Required=false)]
                        public string FieldCode { get; set; }

                        [NameInMap("fieldName")]
                        [Validation(Required=false)]
                        public string FieldName { get; set; }

                        [NameInMap("fieldType")]
                        [Validation(Required=false)]
                        public string FieldType { get; set; }

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

                    [NameInMap("groupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                }

                [NameInMap("templateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("templateInstName")]
                [Validation(Required=false)]
                public string TemplateInstName { get; set; }

                [NameInMap("templateName")]
                [Validation(Required=false)]
                public string TemplateName { get; set; }

                [NameInMap("templateSignStatus")]
                [Validation(Required=false)]
                public int? TemplateSignStatus { get; set; }

                [NameInMap("templateStatus")]
                [Validation(Required=false)]
                public int? TemplateStatus { get; set; }

                [NameInMap("templateType")]
                [Validation(Required=false)]
                public string TemplateType { get; set; }

                [NameInMap("templateTypeName")]
                [Validation(Required=false)]
                public string TemplateTypeName { get; set; }

                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
