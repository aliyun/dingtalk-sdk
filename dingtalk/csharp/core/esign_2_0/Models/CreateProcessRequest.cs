// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class CreateProcessRequest : TeaModel {
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("initiatorUserId")]
        [Validation(Required=false)]
        public string InitiatorUserId { get; set; }

        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("signEndTime")]
        [Validation(Required=false)]
        public long? SignEndTime { get; set; }

        [NameInMap("redirectUrl")]
        [Validation(Required=false)]
        public string RedirectUrl { get; set; }

        [NameInMap("files")]
        [Validation(Required=false)]
        public List<CreateProcessRequestFiles> Files { get; set; }
        public class CreateProcessRequestFiles : TeaModel {
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public int? FileType { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        [NameInMap("participants")]
        [Validation(Required=false)]
        public List<CreateProcessRequestParticipants> Participants { get; set; }
        public class CreateProcessRequestParticipants : TeaModel {
            [NameInMap("signRequirements")]
            [Validation(Required=false)]
            public string SignRequirements { get; set; }

            [NameInMap("signOrder")]
            [Validation(Required=false)]
            public int? SignOrder { get; set; }

            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("dingCorpId")]
            [Validation(Required=false)]
            public string DingCorpId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

        }

        [NameInMap("ccs")]
        [Validation(Required=false)]
        public List<CreateProcessRequestCcs> Ccs { get; set; }
        public class CreateProcessRequestCcs : TeaModel {
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("dingCorpId")]
            [Validation(Required=false)]
            public string DingCorpId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

        }

        [NameInMap("sourceInfo")]
        [Validation(Required=false)]
        public CreateProcessRequestSourceInfo SourceInfo { get; set; }
        public class CreateProcessRequestSourceInfo : TeaModel {
            [NameInMap("showText")]
            [Validation(Required=false)]
            public string ShowText { get; set; }
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }
        };

    }

}
