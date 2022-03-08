// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetActivityListResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetActivityListResponseBodyResult> Result { get; set; }
        public class GetActivityListResponseBodyResult : TeaModel {
            /// <summary>
            /// activityId
            /// </summary>
            [NameInMap("activityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// activityName
            /// </summary>
            [NameInMap("activityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            /// <summary>
            /// activityNameEn
            /// </summary>
            [NameInMap("activityNameInEnglish")]
            [Validation(Required=false)]
            public string ActivityNameInEnglish { get; set; }

        }

    }

}
