// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenAgoalObjectiveDimensionDTO : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("children")]
        [Validation(Required=false)]
        public List<OpenAgoalObjectiveDimensionDTO> Children { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>662e006fe4b0f579bbcxxxxx</para>
        /// </summary>
        [NameInMap("dimensionId")]
        [Validation(Required=false)]
        public string DimensionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fieldConfig")]
        [Validation(Required=false)]
        public List<OpenAgoalFieldMetaDTO> FieldConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fieldValueMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> FieldValueMap { get; set; }

    }

}
