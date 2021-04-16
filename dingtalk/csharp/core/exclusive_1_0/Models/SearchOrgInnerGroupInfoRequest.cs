// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SearchOrgInnerGroupInfoRequest : TeaModel {
        /// <summary>
        /// groupMembersCntEnd
        /// </summary>
        [NameInMap("groupMembersCountEnd")]
        [Validation(Required=false)]
        public int? GroupMembersCountEnd { get; set; }

        /// <summary>
        /// syncToDingpan
        /// </summary>
        [NameInMap("syncToDingpan")]
        [Validation(Required=false)]
        public int? SyncToDingpan { get; set; }

        /// <summary>
        /// groupOwner
        /// </summary>
        [NameInMap("groupOwner")]
        [Validation(Required=false)]
        public string GroupOwner { get; set; }

        /// <summary>
        /// createTimeEnd
        /// </summary>
        [NameInMap("createTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// createTimeStart
        /// </summary>
        [NameInMap("createTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        /// <summary>
        /// uuid
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// groupMembersCntStart
        /// </summary>
        [NameInMap("groupMembersCountStart")]
        [Validation(Required=false)]
        public int? GroupMembersCountStart { get; set; }

        /// <summary>
        /// lastActiveTimeEnd
        /// </summary>
        [NameInMap("lastActiveTimeEnd")]
        [Validation(Required=false)]
        public long? LastActiveTimeEnd { get; set; }

        /// <summary>
        /// operatorUserId
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// groupName
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// pageStart
        /// </summary>
        [NameInMap("pageStart")]
        [Validation(Required=false)]
        public int? PageStart { get; set; }

        /// <summary>
        /// lastActiveTimeStart
        /// </summary>
        [NameInMap("lastActiveTimeStart")]
        [Validation(Required=false)]
        public long? LastActiveTimeStart { get; set; }

    }

}
