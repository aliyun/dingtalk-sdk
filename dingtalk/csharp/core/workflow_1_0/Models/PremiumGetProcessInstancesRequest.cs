// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetProcessInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SWAPP-4C2F4B-example</para>
        /// </summary>
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1633795200000</para>
        /// </summary>
        [NameInMap("endTimeInMills")]
        [Validation(Required=false)]
        public long? EndTimeInMills { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROC-C53-example</para>
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1631289600000</para>
        /// </summary>
        [NameInMap("startTimeInMills")]
        [Validation(Required=false)]
        public long? StartTimeInMills { get; set; }

    }

}
