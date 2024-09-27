// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class ProcessStartRequest : TeaModel {
        [NameInMap("autoStart")]
        [Validation(Required=false)]
        public string AutoStart { get; set; }

        [NameInMap("ccs")]
        [Validation(Required=false)]
        public List<ProcessStartRequestCcs> Ccs { get; set; }
        public class ProcessStartRequestCcs : TeaModel {
            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<ProcessStartRequestFiles> Files { get; set; }
        public class ProcessStartRequestFiles : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("initiatorUserId")]
        [Validation(Required=false)]
        public string InitiatorUserId { get; set; }

        [NameInMap("participants")]
        [Validation(Required=false)]
        public List<ProcessStartRequestParticipants> Participants { get; set; }
        public class ProcessStartRequestParticipants : TeaModel {
            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("signRequirements")]
            [Validation(Required=false)]
            public string SignRequirements { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("redirectUrl")]
        [Validation(Required=false)]
        public string RedirectUrl { get; set; }

        [NameInMap("sourceInfo")]
        [Validation(Required=false)]
        public ProcessStartRequestSourceInfo SourceInfo { get; set; }
        public class ProcessStartRequestSourceInfo : TeaModel {
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

            [NameInMap("showText")]
            [Validation(Required=false)]
            public string ShowText { get; set; }

        }

        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
