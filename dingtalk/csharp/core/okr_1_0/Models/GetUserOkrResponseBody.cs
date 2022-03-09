// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class GetUserOkrResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUserOkrResponseBodyData Data { get; set; }
        public class GetUserOkrResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<GetUserOkrResponseBodyDataList> List { get; set; }
            public class GetUserOkrResponseBodyDataList : TeaModel {
                public List<string> AlignFromIds { get; set; }
                public List<string> AlignToIds { get; set; }
                public Stream Content { get; set; }
                public Stream Id { get; set; }
                public List<GetUserOkrResponseBodyDataListKrList> KrList { get; set; }
                public class GetUserOkrResponseBodyDataListKrList : TeaModel {
                    public Stream Content { get; set; }
                    public Stream Id { get; set; }
                    public Stream ObjectiveId { get; set; }
                    public List<string> Permission { get; set; }
                    public long? Position { get; set; }
                    public GetUserOkrResponseBodyDataListKrListProgress Progress { get; set; }
                    public class GetUserOkrResponseBodyDataListKrListProgress : TeaModel {
                        [NameInMap("percent")]
                        [Validation(Required=false)]
                        public int? Percent { get; set; }

                    }
                    public float? Score { get; set; }
                    public float? Weight { get; set; }
                }
                public GetUserOkrResponseBodyDataListOwner Owner { get; set; }
                public class GetUserOkrResponseBodyDataListOwner : TeaModel {
                    [NameInMap("avatarMediaId")]
                    [Validation(Required=false)]
                    public Stream AvatarMediaId { get; set; }

                    [NameInMap("corpId")]
                    [Validation(Required=false)]
                    public Stream CorpId { get; set; }

                    [NameInMap("department")]
                    [Validation(Required=false)]
                    public GetUserOkrResponseBodyDataListOwnerDepartment Department { get; set; }
                    public class GetUserOkrResponseBodyDataListOwnerDepartment : TeaModel {
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public Stream Id { get; set; }
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public Stream Name { get; set; }
                    };

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public Stream Id { get; set; }

                    [NameInMap("nickname")]
                    [Validation(Required=false)]
                    public Stream Nickname { get; set; }

                    [NameInMap("staffId")]
                    [Validation(Required=false)]
                    public Stream StaffId { get; set; }

                }
                public Stream PeriodId { get; set; }
                public List<string> Permission { get; set; }
                public int? Position { get; set; }
                public GetUserOkrResponseBodyDataListProgress Progress { get; set; }
                public class GetUserOkrResponseBodyDataListProgress : TeaModel {
                    [NameInMap("percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                }
                public float? ProgressPercent { get; set; }
                public bool? Published { get; set; }
                public float? Score { get; set; }
                public int? Status { get; set; }
                public Stream UserId { get; set; }
                public float? Weight { get; set; }
            }
            [NameInMap("pageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        /// <summary>
        /// message
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public Stream Message { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
