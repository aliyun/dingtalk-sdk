// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomGroupListResponseBody : TeaModel {
        /// <summary>
        /// 结果列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryMeetingRoomGroupListResponseBodyResult> Result { get; set; }
        public class QueryMeetingRoomGroupListResponseBodyResult : TeaModel {
            /// <summary>
            /// 分组id
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// 分组名称
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 父分组id
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

        }

    }

}
