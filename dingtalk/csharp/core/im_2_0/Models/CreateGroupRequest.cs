// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class CreateGroupRequest : TeaModel {
        [NameInMap("groupAvatar")]
        [Validation(Required=false)]
        public string GroupAvatar { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("users")]
        [Validation(Required=false)]
        public List<CreateGroupRequestUsers> Users { get; set; }
        public class CreateGroupRequestUsers : TeaModel {
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupOwner")]
            [Validation(Required=false)]
            public bool? GroupOwner { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
