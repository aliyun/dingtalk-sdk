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
            [NameInMap("action")]
            [Validation(Required=false)]
            public int? Action { get; set; }

            [NameInMap("actionView")]
            [Validation(Required=false)]
            public string ActionView { get; set; }

            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("docMemberList")]
            [Validation(Required=false)]
            public List<ListAuditLogResponseBodyListDocMemberList> DocMemberList { get; set; }
            public class ListAuditLogResponseBodyListDocMemberList : TeaModel {
                [NameInMap("memberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("memberType")]
                [Validation(Required=false)]
                public int? MemberType { get; set; }

                [NameInMap("memberTypeView")]
                [Validation(Required=false)]
                public string MemberTypeView { get; set; }

                [NameInMap("permissionRole")]
                [Validation(Required=false)]
                public long? PermissionRole { get; set; }

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
                [NameInMap("receiverName")]
                [Validation(Required=false)]
                public string ReceiverName { get; set; }

                [NameInMap("receiverType")]
                [Validation(Required=false)]
                public int? ReceiverType { get; set; }

                [NameInMap("receiverTypeView")]
                [Validation(Required=false)]
                public string ReceiverTypeView { get; set; }

            }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("ipAddress")]
            [Validation(Required=false)]
            public string IpAddress { get; set; }

            [NameInMap("operateModule")]
            [Validation(Required=false)]
            public long? OperateModule { get; set; }

            [NameInMap("operateModuleView")]
            [Validation(Required=false)]
            public string OperateModuleView { get; set; }

            [NameInMap("operatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public int? Platform { get; set; }

            [NameInMap("platformView")]
            [Validation(Required=false)]
            public string PlatformView { get; set; }

            [NameInMap("realName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            [NameInMap("receiverType")]
            [Validation(Required=false)]
            public int? ReceiverType { get; set; }

            [NameInMap("receiverTypeView")]
            [Validation(Required=false)]
            public string ReceiverTypeView { get; set; }

            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            [NameInMap("resourceExtension")]
            [Validation(Required=false)]
            public string ResourceExtension { get; set; }

            [NameInMap("resourceSize")]
            [Validation(Required=false)]
            public long? ResourceSize { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("targetSpaceId")]
            [Validation(Required=false)]
            public long? TargetSpaceId { get; set; }

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
