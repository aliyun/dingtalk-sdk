// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryAllFormInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SWAPP-dacdsa-example</para>
        /// </summary>
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROC-daccea-example</para>
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100010</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
