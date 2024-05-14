// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetColumnvalsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("columnIdList")]
        [Validation(Required=false)]
        public List<string> ColumnIdList { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fromDate")]
        [Validation(Required=false)]
        public long? FromDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("toDate")]
        [Validation(Required=false)]
        public long? ToDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
