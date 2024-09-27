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
            [NameInMap("orgUsesList")]
            [Validation(Required=false)]
            public List<QueryLiveWatchUserListResponseBodyResultOrgUsesList> OrgUsesList { get; set; }
            public class QueryLiveWatchUserListResponseBodyResultOrgUsesList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.设计部</para>
                /// </summary>
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>李四</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DC7wZGOSueEEIGOf3WKwWgiEiE</para>
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>214675</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>189930</para>
                /// </summary>
                [NameInMap("watchLiveTime")]
                [Validation(Required=false)]
                public long? WatchLiveTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23667</para>
                /// </summary>
                [NameInMap("watchPlaybackTime")]
                [Validation(Required=false)]
                public long? WatchPlaybackTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2330</para>
                /// </summary>
                [NameInMap("watchProgressMs")]
                [Validation(Required=false)]
                public long? WatchProgressMs { get; set; }

            }

            [NameInMap("outOrgUserList")]
            [Validation(Required=false)]
            public List<QueryLiveWatchUserListResponseBodyResultOutOrgUserList> OutOrgUserList { get; set; }
            public class QueryLiveWatchUserListResponseBodyResultOutOrgUserList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23440</para>
                /// </summary>
                [NameInMap("watchLiveTime")]
                [Validation(Required=false)]
                public long? WatchLiveTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2330</para>
                /// </summary>
                [NameInMap("watchPlaybackTime")]
                [Validation(Required=false)]
                public long? WatchPlaybackTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("watchProgressMs")]
                [Validation(Required=false)]
                public long? WatchProgressMs { get; set; }

            }

        }

    }

}
