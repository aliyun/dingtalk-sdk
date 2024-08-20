// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class CreateRecordRequest : TeaModel {
        [NameInMap("attachmentList")]
        [Validation(Required=false)]
        public List<CreateRecordRequestAttachmentList> AttachmentList { get; set; }
        public class CreateRecordRequestAttachmentList : TeaModel {
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("fieldList")]
        [Validation(Required=false)]
        public List<CreateRecordRequestFieldList> FieldList { get; set; }
        public class CreateRecordRequestFieldList : TeaModel {
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("optionId")]
            [Validation(Required=false)]
            public string OptionId { get; set; }

            [NameInMap("options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            [NameInMap("signRequired")]
            [Validation(Required=false)]
            public bool? SignRequired { get; set; }

            [NameInMap("userCustomField")]
            [Validation(Required=false)]
            public bool? UserCustomField { get; set; }

        }

        [NameInMap("groupList")]
        [Validation(Required=false)]
        public List<CreateRecordRequestGroupList> GroupList { get; set; }
        public class CreateRecordRequestGroupList : TeaModel {
            [NameInMap("detailFlag")]
            [Validation(Required=false)]
            public bool? DetailFlag { get; set; }

            [NameInMap("fieldList")]
            [Validation(Required=false)]
            public List<List<CreateRecordRequestGroupListFieldList>> FieldList { get; set; }
            public class CreateRecordRequestGroupListFieldList : TeaModel {
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("fieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

                [NameInMap("options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                [NameInMap("optionId")]
                [Validation(Required=false)]
                public string OptionId { get; set; }

                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

            }

            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("signLastLegalEntityName")]
        [Validation(Required=false)]
        public string SignLastLegalEntityName { get; set; }

        [NameInMap("signLegalEntityName")]
        [Validation(Required=false)]
        public string SignLegalEntityName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("signSource")]
        [Validation(Required=false)]
        public string SignSource { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("signStartUserId")]
        [Validation(Required=false)]
        public string SignStartUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("signUserId")]
        [Validation(Required=false)]
        public string SignUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
