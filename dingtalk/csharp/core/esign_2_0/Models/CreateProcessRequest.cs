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

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

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

        [NameInMap("initiatorUserId")]
        [Validation(Required=false)]
        public string InitiatorUserId { get; set; }

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

            /// <summary>
            /// 参与方签署位置信息列表
            /// </summary>
            [NameInMap("signPosList")]
            [Validation(Required=false)]
            public List<CreateProcessRequestParticipantsSignPosList> SignPosList { get; set; }
            public class CreateProcessRequestParticipantsSignPosList : TeaModel {
                /// <summary>
                /// 文件id
                /// </summary>
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// 是否为骑缝章
                /// </summary>
                [NameInMap("isCrossPage")]
                [Validation(Required=false)]
                public bool? IsCrossPage { get; set; }

                /// <summary>
                /// 是否需要显示签署时间
                /// </summary>
                [NameInMap("needSignDate")]
                [Validation(Required=false)]
                public bool? NeedSignDate { get; set; }

                /// <summary>
                /// 签署区页码
                /// </summary>
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
                };

                /// <summary>
                /// 签署要求,1-企业章 2-经办人
                /// </summary>
                [NameInMap("signRequirement")]
                [Validation(Required=false)]
                public string SignRequirement { get; set; }

                /// <summary>
                /// 签署区x坐标
                /// </summary>
                [NameInMap("x")]
                [Validation(Required=false)]
                public double? X { get; set; }

                /// <summary>
                /// 签署区y坐标
                /// </summary>
                [NameInMap("y")]
                [Validation(Required=false)]
                public double? Y { get; set; }

            }

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
        };

        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
