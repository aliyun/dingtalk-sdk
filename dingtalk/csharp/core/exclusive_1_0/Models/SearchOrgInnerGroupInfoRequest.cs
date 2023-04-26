// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SearchOrgInnerGroupInfoRequest : TeaModel {
        [NameInMap("createTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        [NameInMap("createTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        [NameInMap("groupMembersCountEnd")]
        [Validation(Required=false)]
        public int? GroupMembersCountEnd { get; set; }

        [NameInMap("groupMembersCountStart")]
        [Validation(Required=false)]
        public int? GroupMembersCountStart { get; set; }

        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("groupOwner")]
        [Validation(Required=false)]
        public string GroupOwner { get; set; }

        [NameInMap("lastActiveTimeEnd")]
        [Validation(Required=false)]
        public long? LastActiveTimeEnd { get; set; }

        [NameInMap("lastActiveTimeStart")]
        [Validation(Required=false)]
        public long? LastActiveTimeStart { get; set; }

        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("pageStart")]
        [Validation(Required=false)]
        public int? PageStart { get; set; }

        [NameInMap("syncToDingpan")]
        [Validation(Required=false)]
        public int? SyncToDingpan { get; set; }

        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
