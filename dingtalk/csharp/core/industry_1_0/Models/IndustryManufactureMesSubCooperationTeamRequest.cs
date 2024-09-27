// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesSubCooperationTeamRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>libai</para>
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outTeam</para>
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesSubCooperationTeamRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesSubCooperationTeamRequestExtendData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>school</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>学校</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北大</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        [NameInMap("groupPlugins")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesSubCooperationTeamRequestGroupPlugins> GroupPlugins { get; set; }
        public class IndustryManufactureMesSubCooperationTeamRequestGroupPlugins : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUB_COOPERATION_GROUP</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("leaders")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesSubCooperationTeamRequestLeaders> Leaders { get; set; }
        public class IndustryManufactureMesSubCooperationTeamRequestLeaders : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1919442747879777</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("members")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesSubCooperationTeamRequestMembers> Members { get; set; }
        public class IndustryManufactureMesSubCooperationTeamRequestMembers : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李四</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1919442747879777</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>打磨班组</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingfsdfs3fsd2234wds</para>
        /// </summary>
        [NameInMap("outCorpId")]
        [Validation(Required=false)]
        public string OutCorpId { get; set; }

        [NameInMap("processIds")]
        [Validation(Required=false)]
        public List<string> ProcessIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d41d8cd98f00b204e9800998ecf8427e</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
