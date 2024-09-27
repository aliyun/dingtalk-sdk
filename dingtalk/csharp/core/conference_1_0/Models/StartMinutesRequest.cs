// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StartMinutesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>左上</para>
        /// </summary>
        [NameInMap("ownerUnionId")]
        [Validation(Required=false)]
        public string OwnerUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("recordAudio")]
        [Validation(Required=false)]
        public bool? RecordAudio { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>27SaQ3iiHLN0uwqcPisedfreNwiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
