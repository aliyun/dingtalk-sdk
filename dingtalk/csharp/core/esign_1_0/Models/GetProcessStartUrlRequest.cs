// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class GetProcessStartUrlRequest : TeaModel {
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<GetProcessStartUrlRequestFiles> Files { get; set; }
        public class GetProcessStartUrlRequestFiles : TeaModel {
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("initiatorUserId")]
        [Validation(Required=false)]
        public string InitiatorUserId { get; set; }

        [NameInMap("participants")]
        [Validation(Required=false)]
        public List<GetProcessStartUrlRequestParticipants> Participants { get; set; }
        public class GetProcessStartUrlRequestParticipants : TeaModel {
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("dingCorpId")]
            [Validation(Required=false)]
            public string DingCorpId { get; set; }

            [NameInMap("signRequirements")]
            [Validation(Required=false)]
            public string SignRequirements { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

        }

        [NameInMap("redirectUrl")]
        [Validation(Required=false)]
        public string RedirectUrl { get; set; }

        [NameInMap("sourceInfo")]
        [Validation(Required=false)]
        public GetProcessStartUrlRequestSourceInfo SourceInfo { get; set; }
        public class GetProcessStartUrlRequestSourceInfo : TeaModel {
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }
            [NameInMap("showText")]
            [Validation(Required=false)]
            public string ShowText { get; set; }
        };

        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("ccs")]
        [Validation(Required=false)]
        public List<GetProcessStartUrlRequestCcs> Ccs { get; set; }
        public class GetProcessStartUrlRequestCcs : TeaModel {
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("dingCorpId")]
            [Validation(Required=false)]
            public string DingCorpId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

        }

        [NameInMap("dingIsvAccessToken")]
        [Validation(Required=false)]
        public string DingIsvAccessToken { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

    }

}
