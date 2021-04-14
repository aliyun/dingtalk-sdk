// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class GetDingMeBaseDataRequest : TeaModel {
        /// <summary>
        /// 机器人ID
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startDay")]
        [Validation(Required=false)]
        public string StartDay { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("endDay")]
        [Validation(Required=false)]
        public string EndDay { get; set; }

        /// <summary>
        /// 是否按天分组
        /// </summary>
        [NameInMap("byDay")]
        [Validation(Required=false)]
        public bool? ByDay { get; set; }

    }

}
