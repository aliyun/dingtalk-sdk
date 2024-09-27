// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskTaskflowstatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateTaskTaskflowstatusResponseBodyResult Result { get; set; }
        public class UpdateTaskTaskflowstatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
