// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkreport_1_0.Models
{
    public class QueryReportDetailRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18XXXX</para>
        /// </summary>
        [NameInMap("reportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}
