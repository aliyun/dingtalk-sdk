// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalUserSubAdminListResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<OpenUserSubAdminDTO> Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7478B23C-80E8-1AD6-BE8C-09D480E0xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
