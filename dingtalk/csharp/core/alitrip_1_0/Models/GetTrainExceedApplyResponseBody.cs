// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class GetTrainExceedApplyResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("applyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("applyIntentionInfoDO")]
        [Validation(Required=false)]
        public GetTrainExceedApplyResponseBodyApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
        public class GetTrainExceedApplyResponseBodyApplyIntentionInfoDO : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("arrCity")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("arrCityName")]
            [Validation(Required=false)]
            public string ArrCityName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>上海南</para>
            /// </summary>
            [NameInMap("arrStation")]
            [Validation(Required=false)]
            public string ArrStation { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-13 15:06:13</para>
            /// </summary>
            [NameInMap("arrTime")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA</para>
            /// </summary>
            [NameInMap("depCity")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>上海</para>
            /// </summary>
            [NameInMap("depCityName")]
            [Validation(Required=false)]
            public string DepCityName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京南</para>
            /// </summary>
            [NameInMap("depStation")]
            [Validation(Required=false)]
            public string DepStation { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-13 15:06:13</para>
            /// </summary>
            [NameInMap("depTime")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>一等座</para>
            /// </summary>
            [NameInMap("seatName")]
            [Validation(Required=false)]
            public string SeatName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>G39</para>
            /// </summary>
            [NameInMap("trainNo")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>高铁</para>
            /// </summary>
            [NameInMap("trainTypeDesc")]
            [Validation(Required=false)]
            public string TrainTypeDesc { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>出差</para>
        /// </summary>
        [NameInMap("btripCause")]
        [Validation(Required=false)]
        public string BtripCause { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding12345</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>出差</para>
        /// </summary>
        [NameInMap("exceedReason")]
        [Validation(Required=false)]
        public string ExceedReason { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("exceedType")]
        [Validation(Required=false)]
        public int? ExceedType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>二等座</para>
        /// </summary>
        [NameInMap("originStandard")]
        [Validation(Required=false)]
        public string OriginStandard { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-08 15:23:56</para>
        /// </summary>
        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0001A1100000007EX08O</para>
        /// </summary>
        [NameInMap("thirdpartApplyId")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weifeng</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
