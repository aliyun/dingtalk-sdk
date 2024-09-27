// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetRelatedViewTabDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PROC-62829702-A377-42A9-9CB3-E1C691A0CEDB</para>
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OpenDataField_OV2K4SOW2ZGG</para>
        /// </summary>
        [NameInMap("relatedField")]
        [Validation(Required=false)]
        public string RelatedField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>u_dxcugzT0aPQvcK2PIkzQ00841721291058</para>
        /// </summary>
        [NameInMap("relatedInstId")]
        [Validation(Required=false)]
        public string RelatedInstId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager6034</para>
        /// </summary>
        [NameInMap("viewUserId")]
        [Validation(Required=false)]
        public string ViewUserId { get; set; }

    }

}
