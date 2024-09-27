// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class DataSyncResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> DataList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("rowsAffected")]
        [Validation(Required=false)]
        public int? RowsAffected { get; set; }

    }

}
