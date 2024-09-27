// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetLatestDingIndexResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("idxCarbon")]
        [Validation(Required=false)]
        public float? IdxCarbon { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("idxEfficiency")]
        [Validation(Required=false)]
        public float? IdxEfficiency { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>888</para>
        /// </summary>
        [NameInMap("idxMonthlyAvg")]
        [Validation(Required=false)]
        public float? IdxMonthlyAvg { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>888</para>
        /// </summary>
        [NameInMap("idxTotal")]
        [Validation(Required=false)]
        public float? IdxTotal { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20210412</para>
        /// </summary>
        [NameInMap("statDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

    }

}
