// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class CreateProcessRequest : TeaModel {
        [NameInMap("ccs")]
        [Validation(Required=false)]
        public List<CreateProcessRequestCcs> Ccs { get; set; }
        public class CreateProcessRequestCcs : TeaModel {
            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// This parameter is required.
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

        [NameInMap("files")]
        [Validation(Required=false)]
        public List<CreateProcessRequestFiles> Files { get; set; }
        public class CreateProcessRequestFiles : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public int? FileType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("initiatorUserId")]
        [Validation(Required=false)]
        public string InitiatorUserId { get; set; }

        [NameInMap("participants")]
        [Validation(Required=false)]
        public List<CreateProcessRequestParticipants> Participants { get; set; }
        public class CreateProcessRequestParticipants : TeaModel {
            [NameInMap("account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("signOrder")]
            [Validation(Required=false)]
            public int? SignOrder { get; set; }

            [NameInMap("signPosList")]
            [Validation(Required=false)]
            public List<CreateProcessRequestParticipantsSignPosList> SignPosList { get; set; }
            public class CreateProcessRequestParticipantsSignPosList : TeaModel {
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("isCrossPage")]
                [Validation(Required=false)]
                public bool? IsCrossPage { get; set; }

                [NameInMap("needSignDate")]
                [Validation(Required=false)]
                public bool? NeedSignDate { get; set; }

                [NameInMap("page")]
                [Validation(Required=false)]
                public string Page { get; set; }

                [NameInMap("signDate")]
                [Validation(Required=false)]
                public CreateProcessRequestParticipantsSignPosListSignDate SignDate { get; set; }
                public class CreateProcessRequestParticipantsSignPosListSignDate : TeaModel {
                    [NameInMap("format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                }

                [NameInMap("signRequirement")]
                [Validation(Required=false)]
                public string SignRequirement { get; set; }

                [NameInMap("x")]
                [Validation(Required=false)]
                public double? X { get; set; }

                [NameInMap("y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
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

        [NameInMap("signEndTime")]
        [Validation(Required=false)]
        public long? SignEndTime { get; set; }

        [NameInMap("sourceInfo")]
        [Validation(Required=false)]
        public CreateProcessRequestSourceInfo SourceInfo { get; set; }
        public class CreateProcessRequestSourceInfo : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
