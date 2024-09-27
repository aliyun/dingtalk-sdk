// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class ListFormInstancesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-01-01</para>
        /// </summary>
        [NameInMap("actionDate")]
        [Validation(Required=false)]
        public string ActionDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

    }

}
