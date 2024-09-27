// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreatePhysicalClassroomRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>主楼</para>
        /// </summary>
        [NameInMap("classroomBuilding")]
        [Validation(Required=false)]
        public string ClassroomBuilding { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>主校区</para>
        /// </summary>
        [NameInMap("classroomCampus")]
        [Validation(Required=false)]
        public string ClassroomCampus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2层</para>
        /// </summary>
        [NameInMap("classroomFloor")]
        [Validation(Required=false)]
        public string ClassroomFloor { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>实验室</para>
        /// </summary>
        [NameInMap("classroomName")]
        [Validation(Required=false)]
        public string ClassroomName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201</para>
        /// </summary>
        [NameInMap("classroomNumber")]
        [Validation(Required=false)]
        public string ClassroomNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y</para>
        /// </summary>
        [NameInMap("directBroadcast")]
        [Validation(Required=false)]
        public string DirectBroadcast { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manger1234</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
