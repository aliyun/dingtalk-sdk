// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenAgoalOrgObjectiveDTO : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dimension")]
        [Validation(Required=false)]
        public OpenAgoalObjectiveDimensionDTO Dimension { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("downAlignObjects")]
        [Validation(Required=false)]
        public List<OpenAgoalAlignDTO> DownAlignObjects { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("executor")]
        [Validation(Required=false)]
        public OpenAgoalUserDTO Executor { get; set; }

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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6444f5e9a4261c6e699dxxxx</para>
        /// </summary>
        [NameInMap("objectiveId")]
        [Validation(Required=false)]
        public string ObjectiveId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public OpenObjectiveRulePeriodDTO Period { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>formalEffective</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("team")]
        [Validation(Required=false)]
        public OpenAgoalTeamDTO Team { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试目标</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("upAlignObjects")]
        [Validation(Required=false)]
        public List<OpenAgoalAlignDTO> UpAlignObjects { get; set; }

    }

}
