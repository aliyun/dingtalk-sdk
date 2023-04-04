// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListAuditLogResponseBody : TeaModel {
        /// <summary>
        /// 记录列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListAuditLogResponseBodyList> List { get; set; }
        public class ListAuditLogResponseBodyList : TeaModel {
            /// <summary>
            /// 操作类型
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public int? Action { get; set; }

            /// <summary>
            /// 操作类型翻译值
            /// </summary>
            [NameInMap("actionView")]
            [Validation(Required=false)]
            public string ActionView { get; set; }

            /// <summary>
            /// 文件id
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// 接收成员列表，仅分享文档返回
            /// </summary>
            [NameInMap("docMemberList")]
            [Validation(Required=false)]
            public List<ListAuditLogResponseBodyListDocMemberList> DocMemberList { get; set; }
            public class ListAuditLogResponseBodyListDocMemberList : TeaModel {
                /// <summary>
                /// 成员名称
                /// </summary>
                [NameInMap("memberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// 成员类型
                /// </summary>
                [NameInMap("memberType")]
                [Validation(Required=false)]
                public int? MemberType { get; set; }

                /// <summary>
                /// 成员类型翻译值
                /// </summary>
                [NameInMap("memberTypeView")]
                [Validation(Required=false)]
                public string MemberTypeView { get; set; }

                /// <summary>
                /// 权限类型
                /// </summary>
                [NameInMap("permissionRole")]
                [Validation(Required=false)]
                public long? PermissionRole { get; set; }

                /// <summary>
                /// 权限类型翻译值
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

            /// <summary>
            /// 成员授权列表，仅文档授权返回
            /// </summary>
            [NameInMap("docReceiverList")]
            [Validation(Required=false)]
            public List<ListAuditLogResponseBodyListDocReceiverList> DocReceiverList { get; set; }
            public class ListAuditLogResponseBodyListDocReceiverList : TeaModel {
                /// <summary>
                /// 成员名称
                /// </summary>
                [NameInMap("receiverName")]
                [Validation(Required=false)]
                public string ReceiverName { get; set; }

                /// <summary>
                /// 成员类型
                /// </summary>
                [NameInMap("receiverType")]
                [Validation(Required=false)]
                public int? ReceiverType { get; set; }

                /// <summary>
                /// 成员类型翻译值
                /// </summary>
                [NameInMap("receiverTypeView")]
                [Validation(Required=false)]
                public string ReceiverTypeView { get; set; }

            }

            /// <summary>
            /// 记录生成时间，unix时间戳，单位ms
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 记录修改时间，unix时间戳，单位ms
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// 操作机器ip
            /// </summary>
            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            /// <summary>
            /// 操作来源空间
            /// </summary>
            [NameInMap("operateModule")]
            [Validation(Required=false)]
            public long? OperateModule { get; set; }

            /// <summary>
            /// 操作来源翻译值
            /// </summary>
            [NameInMap("operateModuleView")]
            [Validation(Required=false)]
            public string OperateModuleView { get; set; }

            /// <summary>
            /// 用户昵称
            /// </summary>
            [NameInMap("operatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// 文件所属组织名称
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// 操作端
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public int? Platform { get; set; }

            /// <summary>
            /// 操作端翻译值
            /// </summary>
            [NameInMap("platformView")]
            [Validation(Required=false)]
            public string PlatformView { get; set; }

            /// <summary>
            /// 用户姓名
            /// </summary>
            [NameInMap("realName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// 文件接收方名称
            /// </summary>
            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            /// <summary>
            /// 文件接收方类型
            /// </summary>
            [NameInMap("receiverType")]
            [Validation(Required=false)]
            public int? ReceiverType { get; set; }

            /// <summary>
            /// 文件接收方类型翻译值
            /// </summary>
            [NameInMap("receiverTypeView")]
            [Validation(Required=false)]
            public string ReceiverTypeView { get; set; }

            /// <summary>
            /// test.docx
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// 文件类型
            /// </summary>
            [NameInMap("resourceExtension")]
            [Validation(Required=false)]
            public string ResourceExtension { get; set; }

            /// <summary>
            /// 文件大小
            /// </summary>
            [NameInMap("resourceSize")]
            [Validation(Required=false)]
            public long? ResourceSize { get; set; }

            /// <summary>
            /// 记录状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 空间id
            /// </summary>
            [NameInMap("targetSpaceId")]
            [Validation(Required=false)]
            public long? TargetSpaceId { get; set; }

            /// <summary>
            /// 员工的userId
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
