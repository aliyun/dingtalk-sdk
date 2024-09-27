// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryOfficialDatasetFieldsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding3xxx__-PROC-42FF6625-9692-4003-B13C-307CAACEC354</para>
        /// </summary>
        [NameInMap("dsId")]
        [Validation(Required=false)]
        public string DsId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
