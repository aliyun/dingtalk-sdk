// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreRightsInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1659668620000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RIGHT_MDT_LEVEL</para>
        /// </summary>
        [NameInMap("rightsCode")]
        [Validation(Required=false)]
        public string RightsCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>高级版</para>
        /// </summary>
        [NameInMap("rightsName")]
        [Validation(Required=false)]
        public string RightsName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1656990220000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
