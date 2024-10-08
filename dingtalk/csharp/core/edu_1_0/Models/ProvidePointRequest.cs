// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ProvidePointRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>action01</para>
        /// </summary>
        [NameInMap("actionCode")]
        [Validation(Required=false)]
        public string ActionCode { get; set; }

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
        /// <para>personal</para>
        /// </summary>
        [NameInMap("pointType")]
        [Validation(Required=false)]
        public string PointType { get; set; }

    }

}
