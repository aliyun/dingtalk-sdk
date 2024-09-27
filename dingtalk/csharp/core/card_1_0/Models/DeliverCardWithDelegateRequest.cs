// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class DeliverCardWithDelegateRequest : TeaModel {
        [NameInMap("coFeedOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestCoFeedOpenDeliverModel CoFeedOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestCoFeedOpenDeliverModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx_biz_tag</para>
            /// </summary>
            [NameInMap("bizTag")]
            [Validation(Required=false)]
            public string BizTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1665473229000</para>
            /// </summary>
            [NameInMap("gmtTimeLine")]
            [Validation(Required=false)]
            public long? GmtTimeLine { get; set; }

        }

        [NameInMap("docOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestDocOpenDeliverModel DocOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestDocOpenDeliverModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx_biz_tag</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("imGroupOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestImGroupOpenDeliverModel ImGroupOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestImGroupOpenDeliverModel : TeaModel {
            [NameInMap("atUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> AtUserIds { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("recipients")]
            [Validation(Required=false)]
            public List<string> Recipients { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingg3xmqdkpaojuakm8</para>
            /// </summary>
            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

        }

        [NameInMap("imRobotOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestImRobotOpenDeliverModel ImRobotOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestImRobotOpenDeliverModel : TeaModel {
            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingg3xmqdkpaojuakm8</para>
            /// </summary>
            [NameInMap("robotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IM_ROBOT</para>
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

        }

        [NameInMap("imSingleOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestImSingleOpenDeliverModel ImSingleOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestImSingleOpenDeliverModel : TeaModel {
            [NameInMap("atUserIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> AtUserIds { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtv1.card//im_group.cidp4Gh<em><b><b><b>VCQ==;im_robot.manager</b></b>67;co_feed.manager</b></em><em>67;one_box.cidp4Gh</em>******VCQ==</para>
        /// </summary>
        [NameInMap("openSpaceId")]
        [Validation(Required=false)]
        public string OpenSpaceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>out_track_id_123456</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("topOpenDeliverModel")]
        [Validation(Required=false)]
        public DeliverCardWithDelegateRequestTopOpenDeliverModel TopOpenDeliverModel { get; set; }
        public class DeliverCardWithDelegateRequestTopOpenDeliverModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1665473229000</para>
            /// </summary>
            [NameInMap("expiredTimeMillis")]
            [Validation(Required=false)]
            public long? ExpiredTimeMillis { get; set; }

            [NameInMap("platforms")]
            [Validation(Required=false)]
            public List<string> Platforms { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("userIdType")]
        [Validation(Required=false)]
        public int? UserIdType { get; set; }

    }

}
