// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateCustomShortLinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COOLAPP-0-1026633886192127xxxB000W</para>
        /// </summary>
        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
        /// </summary>
        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bizData</para>
        /// </summary>
        [NameInMap("extensionAppBizData")]
        [Validation(Required=false)]
        public string ExtensionAppBizData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f6fb627e-a7e8-403e-b1f8-26e85450f4a9</para>
        /// </summary>
        [NameInMap("scheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true：使用 false：不使用</para>
        /// </summary>
        [NameInMap("useExtensionApp")]
        [Validation(Required=false)]
        public bool? UseExtensionApp { get; set; }

    }

}
