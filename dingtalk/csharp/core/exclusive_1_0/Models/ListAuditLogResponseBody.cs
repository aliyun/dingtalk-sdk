// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListAuditLogResponseBody : TeaModel {
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListAuditLogResponseBodyList> List { get; set; }
        public class ListAuditLogResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public int? Action { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>企业群</para>
            /// </summary>
            [NameInMap("actionView")]
            [Validation(Required=false)]
            public string ActionView { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11258620701</para>
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("docMemberList")]
            [Validation(Required=false)]
            public List<ListAuditLogResponseBodyListDocMemberList> DocMemberList { get; set; }
            public class ListAuditLogResponseBodyListDocMemberList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("memberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("memberType")]
                [Validation(Required=false)]
                public int? MemberType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>部门</para>
                /// </summary>
                [NameInMap("memberTypeView")]
                [Validation(Required=false)]
                public string MemberTypeView { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("permissionRole")]
                [Validation(Required=false)]
                public long? PermissionRole { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>阅读者（可查看\下载）</para>
                /// </summary>
                [NameInMap("permissionRoleView")]
                [Validation(Required=false)]
                public string PermissionRoleView { get; set; }

            }

            [NameInMap("docMobileUrl")]
            [Validation(Required=false)]
            public string DocMobileUrl { get; set; }

            [NameInMap("docPcUrl")]
            [Validation(Required=false)]
            public string DocPcUrl { get; set; }

            [NameInMap("docReceiverList")]
            [Validation(Required=false)]
            public List<ListAuditLogResponseBodyListDocReceiverList> DocReceiverList { get; set; }
            public class ListAuditLogResponseBodyListDocReceiverList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("receiverName")]
                [Validation(Required=false)]
                public string ReceiverName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("receiverType")]
                [Validation(Required=false)]
                public int? ReceiverType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>单聊</para>
                /// </summary>
                [NameInMap("receiverTypeView")]
                [Validation(Required=false)]
                public string ReceiverTypeView { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1577601221260</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1577601221260</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("operateModule")]
            [Validation(Required=false)]
            public long? OperateModule { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>企业群</para>
            /// </summary>
            [NameInMap("operateModuleView")]
            [Validation(Required=false)]
            public string OperateModuleView { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("operatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>水果公司</para>
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public int? Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WIN</para>
            /// </summary>
            [NameInMap("platformView")]
            [Validation(Required=false)]
            public string PlatformView { get; set; }

            [NameInMap("prevWorkSpaceId")]
            [Validation(Required=false)]
            public long? PrevWorkSpaceId { get; set; }

            [NameInMap("prevWorkSpaceMobileUrl")]
            [Validation(Required=false)]
            public string PrevWorkSpaceMobileUrl { get; set; }

            [NameInMap("prevWorkSpaceName")]
            [Validation(Required=false)]
            public string PrevWorkSpaceName { get; set; }

            [NameInMap("prevWorkSpacePcUrl")]
            [Validation(Required=false)]
            public string PrevWorkSpacePcUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("realName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>总经理办公室</para>
            /// </summary>
            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("receiverType")]
            [Validation(Required=false)]
            public int? ReceiverType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>单聊</para>
            /// </summary>
            [NameInMap("receiverTypeView")]
            [Validation(Required=false)]
            public string ReceiverTypeView { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>文件名</para>
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>doc</para>
            /// </summary>
            [NameInMap("resourceExtension")]
            [Validation(Required=false)]
            public string ResourceExtension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("resourceSize")]
            [Validation(Required=false)]
            public long? ResourceSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11258620</para>
            /// </summary>
            [NameInMap("targetSpaceId")]
            [Validation(Required=false)]
            public long? TargetSpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("workSpaceId")]
            [Validation(Required=false)]
            public long? WorkSpaceId { get; set; }

            [NameInMap("workSpaceMobileUrl")]
            [Validation(Required=false)]
            public string WorkSpaceMobileUrl { get; set; }

            [NameInMap("workSpaceName")]
            [Validation(Required=false)]
            public string WorkSpaceName { get; set; }

            [NameInMap("workSpacePcUrl")]
            [Validation(Required=false)]
            public string WorkSpacePcUrl { get; set; }

        }

    }

}
