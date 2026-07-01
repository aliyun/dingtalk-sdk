// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomGroupAdminResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryMeetingRoomGroupAdminResponseBodyResult Result { get; set; }
        public class QueryMeetingRoomGroupAdminResponseBodyResult : TeaModel {
            [NameInMap("groupAdmins")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins> GroupAdmins { get; set; }
            public class QueryMeetingRoomGroupAdminResponseBodyResultGroupAdmins : TeaModel {
                [NameInMap("memberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("memberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

    }

}
