// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class GetDingMeBaseDataRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("byDay")]
        [Validation(Required=false)]
        public bool? ByDay { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("endDay")]
        [Validation(Required=false)]
        public string EndDay { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("startDay")]
        [Validation(Required=false)]
        public string StartDay { get; set; }

    }

}
