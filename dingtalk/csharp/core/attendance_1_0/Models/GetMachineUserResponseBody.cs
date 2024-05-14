// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetMachineUserResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMachineUserResponseBodyResult Result { get; set; }
        public class GetMachineUserResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userList")]
            [Validation(Required=false)]
            public List<GetMachineUserResponseBodyResultUserList> UserList { get; set; }
            public class GetMachineUserResponseBodyResultUserList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("hasFace")]
                [Validation(Required=false)]
                public bool? HasFace { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
