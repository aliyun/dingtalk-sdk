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
            /// <para><a href="https://dt-staging-moka-public.oss-cn-zhangjiakou.aliyuncs.com/form/attachment/b32509e4a809cb4e18a72fc4aa75e655.pdf">https://dt-staging-moka-public.oss-cn-zhangjiakou.aliyuncs.com/form/attachment/b32509e4a809cb4e18a72fc4aa75e655.pdf</a></para>
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>attachment</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>908608088</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("fieldList")]
        [Validation(Required=false)]
        public List<CreateRecordRequestFieldList> FieldList { get; set; }
        public class CreateRecordRequestFieldList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>contract.contract_type</para>
            /// </summary>
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>合同类型</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DDSelectField</para>
            /// </summary>
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>劳动合同</para>
            /// </summary>
            [NameInMap("fieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>contract</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>劳动合同</para>
            /// </summary>
            [NameInMap("optionId")]
            [Validation(Required=false)]
            public string OptionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[{&quot;label&quot;:&quot;劳动合同&quot;,&quot;value&quot;:&quot;劳动合同&quot;},{&quot;label&quot;:&quot;保密协议&quot;,&quot;value&quot;:&quot;保密协议&quot;}]</para>
            /// </summary>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>contract.contract_type</para>
                /// </summary>
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>合同类型</para>
                /// </summary>
                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DDSelectField</para>
                /// </summary>
                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>劳动合同</para>
                /// </summary>
                [NameInMap("fieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;label&quot;:&quot;劳动合同&quot;,&quot;value&quot;:&quot;劳动合同&quot;},{&quot;label&quot;:&quot;培训协议&quot;,&quot;value&quot;:&quot;培训协议&quot;}]</para>
                /// </summary>
                [NameInMap("options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>劳动合同</para>
                /// </summary>
                [NameInMap("optionId")]
                [Validation(Required=false)]
                public string OptionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>contract</para>
                /// </summary>
                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

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
        /// <para>xxx员工劳动合同电子签署</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx有限公司</para>
        /// </summary>
        [NameInMap("signLastLegalEntityName")]
        [Validation(Required=false)]
        public string SignLastLegalEntityName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx有限公司</para>
        /// </summary>
        [NameInMap("signLegalEntityName")]
        [Validation(Required=false)]
        public string SignLegalEntityName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CONTRACT</para>
        /// </summary>
        [NameInMap("signSource")]
        [Validation(Required=false)]
        public string SignSource { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48510731071405348944</para>
        /// </summary>
        [NameInMap("signStartUserId")]
        [Validation(Required=false)]
        public string SignStartUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>660658</para>
        /// </summary>
        [NameInMap("signUserId")]
        [Validation(Required=false)]
        public string SignUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ad11eb3daa24a9692037079e0732f13</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
