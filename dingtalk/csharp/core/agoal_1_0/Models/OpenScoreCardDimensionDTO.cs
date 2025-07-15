// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenScoreCardDimensionDTO : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dimensionList")]
        [Validation(Required=false)]
        public List<OpenScoreCardDimensionDTODimensionList> DimensionList { get; set; }
        public class OpenScoreCardDimensionDTODimensionList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dimensionId")]
            [Validation(Required=false)]
            public string DimensionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("indicatorIdList")]
            [Validation(Required=false)]
            public List<string> IndicatorIdList { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("scoreCardId")]
        [Validation(Required=false)]
        public string ScoreCardId { get; set; }

    }

}
