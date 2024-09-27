// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StartCloudRecordRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>演讲</para>
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>左上</para>
        /// </summary>
        [NameInMap("smallWindowPosition")]
        [Validation(Required=false)]
        public string SmallWindowPosition { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27SaQ3iiHLN0uwqcPisedfreNwiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
