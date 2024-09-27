// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class ConsumeUserPointsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwe123</para>
        /// </summary>
        [NameInMap("outId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试积分扣减</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OPEN_EMP_POINT_CONSUME_DEFAULT</para>
        /// </summary>
        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
