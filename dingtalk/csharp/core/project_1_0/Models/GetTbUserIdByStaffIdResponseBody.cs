// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetTbUserIdByStaffIdResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTbUserIdByStaffIdResponseBodyResult Result { get; set; }
        public class GetTbUserIdByStaffIdResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("tbUserId")]
            [Validation(Required=false)]
            public string TbUserId { get; set; }

        }

    }

}
