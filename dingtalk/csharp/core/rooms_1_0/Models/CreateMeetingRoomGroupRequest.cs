// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class CreateMeetingRoomGroupRequest : TeaModel {
        /// <summary>
        /// 分组名称
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 父分组id
        /// </summary>
        [NameInMap("parentGroupId")]
        [Validation(Required=false)]
        public long? ParentGroupId { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}