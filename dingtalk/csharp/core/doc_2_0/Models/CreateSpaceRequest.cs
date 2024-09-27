// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CreateSpaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>这里是知识库的简介</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i1/O1***.png">https://img.alicdn.com/imgextra/i1/O1***.png</a></para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试知识库</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YEp3JcM******UIbhwiE</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>l6gYG9****mo9Z</para>
        /// </summary>
        [NameInMap("sectionId")]
        [Validation(Required=false)]
        public string SectionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("shareScope")]
        [Validation(Required=false)]
        public CreateSpaceRequestShareScope ShareScope { get; set; }
        public class CreateSpaceRequestShareScope : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public int? Scope { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5YRB***GDAr</para>
        /// </summary>
        [NameInMap("teamId")]
        [Validation(Required=false)]
        public string TeamId { get; set; }

    }

}
