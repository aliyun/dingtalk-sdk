// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalgo_1_0.Models
{
    public class WeiqiaoAluminumSubmitRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{         &quot;sample_1&quot;: {             &quot;Weight&quot;: 102000,             &quot;Al&quot;: 97, &quot;Si&quot;: 0.05, &quot;Fe&quot;: 0.05         },         &quot;sample_2&quot;: {             &quot;Weight&quot;: 102000,             &quot;Al&quot;: 98, &quot;Si&quot;: 0.04, &quot;Fe&quot;: 0.05         }     }</para>
        /// </summary>
        [NameInMap("current_furnace")]
        [Validation(Required=false)]
        public object CurrentFurnace { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("dilution_config")]
        [Validation(Required=false)]
        public object DilutionConfig { get; set; }

        [NameInMap("history_furnace")]
        [Validation(Required=false)]
        public object HistoryFurnace { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[         {             &quot;Name&quot;: &quot;Al-Si-Material&quot;,             &quot;Primary_element&quot;: &quot;Si&quot;,             &quot;Si&quot;: 10.0, &quot;Al&quot;: 90.0         },         {             &quot;Name&quot;: &quot;Al-Fe-Material&quot;,             &quot;Primary_element&quot;: &quot;Fe&quot;,             &quot;Fe&quot;: 10.0, &quot;Al&quot;: 90.0         }     ]</para>
        /// </summary>
        [NameInMap("raw_materials")]
        [Validation(Required=false)]
        public object RawMaterials { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_batch_001</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public object Target { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{         &quot;Si&quot;: [0.1, 0.2, 0.3],         &quot;Fe&quot;: [0.1, 0.2, 0.3]     }</para>
        /// </summary>
        [NameInMap("target_ranges")]
        [Validation(Required=false)]
        public object TargetRanges { get; set; }

    }

}
