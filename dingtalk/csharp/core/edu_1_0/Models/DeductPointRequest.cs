// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class DeductPointRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>biz01</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>兑换商品</para>
        /// </summary>
        [NameInMap("deductDesc")]
        [Validation(Required=false)]
        public string DeductDesc { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></para>
        /// </summary>
        [NameInMap("deductDetailUrl")]
        [Validation(Required=false)]
        public string DeductDetailUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deductNum")]
        [Validation(Required=false)]
        public int? DeductNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>personal</para>
        /// </summary>
        [NameInMap("pointType")]
        [Validation(Required=false)]
        public string PointType { get; set; }

    }

}
