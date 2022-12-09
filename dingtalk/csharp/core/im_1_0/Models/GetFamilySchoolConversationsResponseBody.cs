// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetFamilySchoolConversationsResponseBody : TeaModel {
        [NameInMap("groupInfoList")]
        [Validation(Required=false)]
        public List<GetFamilySchoolConversationsResponseBodyGroupInfoList> GroupInfoList { get; set; }
        public class GetFamilySchoolConversationsResponseBodyGroupInfoList : TeaModel {
            /// <summary>
            /// 企业名称
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 部门名称链
            /// </summary>
            [NameInMap("deptNameChain")]
            [Validation(Required=false)]
            public List<string> DeptNameChain { get; set; }

            /// <summary>
            /// 群名称
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 群类型
            /// </summary>
            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            /// <summary>
            /// 进群时间
            /// </summary>
            [NameInMap("joinGroupTime")]
            [Validation(Required=false)]
            public long? JoinGroupTime { get; set; }

            /// <summary>
            /// 群开放ID
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        /// <summary>
        /// 是否还有数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        /// <summary>
        /// 返回下一页游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
