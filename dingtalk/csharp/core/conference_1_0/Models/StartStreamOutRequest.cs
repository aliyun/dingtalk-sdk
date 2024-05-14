// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StartStreamOutRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("needHostJoin")]
        [Validation(Required=false)]
        public bool? NeedHostJoin { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("smallWindowPosition")]
        [Validation(Required=false)]
        public string SmallWindowPosition { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("streamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("streamUrlList")]
        [Validation(Required=false)]
        public List<string> StreamUrlList { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
