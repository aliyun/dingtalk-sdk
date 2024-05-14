// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalgo_1_0.Models
{
    public class NlpWordDistinguishResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("wordEntities")]
        [Validation(Required=false)]
        public List<NlpWordDistinguishResponseBodyWordEntities> WordEntities { get; set; }
        public class NlpWordDistinguishResponseBodyWordEntities : TeaModel {
            [NameInMap("word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

    }

}
