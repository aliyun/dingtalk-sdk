// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetPublishAuditResponseBody : TeaModel {
        [NameInMap("audit")]
        [Validation(Required=false)]
        public GetPublishAuditResponseBodyAudit Audit { get; set; }
        public class GetPublishAuditResponseBodyAudit : TeaModel {
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("appIcon")]
            [Validation(Required=false)]
            public string AppIcon { get; set; }

            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("approvalContent")]
            [Validation(Required=false)]
            public string ApprovalContent { get; set; }

            [NameInMap("auditId")]
            [Validation(Required=false)]
            public string AuditId { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("releaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            [NameInMap("sceneType")]
            [Validation(Required=false)]
            public long? SceneType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("submitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("versionDetailUrl")]
            [Validation(Required=false)]
            public string VersionDetailUrl { get; set; }

            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}
