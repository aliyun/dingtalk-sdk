// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QueryLiveWatchUserListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryLiveWatchUserListResponseBodyResult Result { get; set; }
        public class QueryLiveWatchUserListResponseBodyResult : TeaModel {
            /// <summary>
            /// 组织内的观看用户列表
            /// </summary>
            [NameInMap("orgUsesList")]
            [Validation(Required=false)]
            public List<QueryLiveWatchUserListResponseBodyResultOrgUsesList> OrgUsesList { get; set; }
            public class QueryLiveWatchUserListResponseBodyResultOrgUsesList : TeaModel {
                /// <summary>
                /// 部门名称
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// 姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 用户id
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                /// <summary>
                /// 员工id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// 观看直播时长
                /// </summary>
                [NameInMap("watchLiveTime")]
                [Validation(Required=false)]
                public long? WatchLiveTime { get; set; }

                /// <summary>
                /// 观看回放时长
                /// </summary>
                [NameInMap("watchPlaybackTime")]
                [Validation(Required=false)]
                public long? WatchPlaybackTime { get; set; }

                /// <summary>
                /// 回放观看进度
                /// </summary>
                [NameInMap("watchProgressMs")]
                [Validation(Required=false)]
                public long? WatchProgressMs { get; set; }

            }

            /// <summary>
            /// 组织外的观看用户列表
            /// </summary>
            [NameInMap("outOrgUserList")]
            [Validation(Required=false)]
            public List<QueryLiveWatchUserListResponseBodyResultOutOrgUserList> OutOrgUserList { get; set; }
            public class QueryLiveWatchUserListResponseBodyResultOutOrgUserList : TeaModel {
                /// <summary>
                /// 姓名
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 观看直播时长
                /// </summary>
                [NameInMap("watchLiveTime")]
                [Validation(Required=false)]
                public long? WatchLiveTime { get; set; }

                /// <summary>
                /// 观看回放时长
                /// </summary>
                [NameInMap("watchPlaybackTime")]
                [Validation(Required=false)]
                public long? WatchPlaybackTime { get; set; }

                /// <summary>
                /// 回放观看进度
                /// </summary>
                [NameInMap("watchProgressMs")]
                [Validation(Required=false)]
                public long? WatchProgressMs { get; set; }

            }

        }

    }

}
