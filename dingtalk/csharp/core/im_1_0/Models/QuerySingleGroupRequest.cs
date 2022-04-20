// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QuerySingleGroupRequest : TeaModel {
        /// <summary>
        /// 群成员列表
        /// </summary>
        [NameInMap("groupMembers")]
        [Validation(Required=false)]
        public List<QuerySingleGroupRequestGroupMembers> GroupMembers { get; set; }
        public class QuerySingleGroupRequestGroupMembers : TeaModel {
            /// <summary>
            /// 客户appUserId
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// 客服钉钉Id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 群模版Id
        /// </summary>
        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

    }

}
