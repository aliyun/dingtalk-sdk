// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class ExportPointOpenRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20220601</para>
        /// </summary>
        [NameInMap("exportDate")]
        [Validation(Required=false)]
        public string ExportDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("exportType")]
        [Validation(Required=false)]
        public long? ExportType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11185568-1380470824</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
