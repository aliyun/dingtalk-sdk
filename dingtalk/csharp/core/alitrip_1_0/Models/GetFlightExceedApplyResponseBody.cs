// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class GetFlightExceedApplyResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("applyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("applyIntentionInfoDO")]
        [Validation(Required=false)]
        public GetFlightExceedApplyResponseBodyApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
        public class GetFlightExceedApplyResponseBodyApplyIntentionInfoDO : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HGH</para>
            /// </summary>
            [NameInMap("arrCity")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("arrCityName")]
            [Validation(Required=false)]
            public string ArrCityName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-08 15:23:56</para>
            /// </summary>
            [NameInMap("arrTime")]
            [Validation(Required=false)]
            public string ArrTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("cabin")]
            [Validation(Required=false)]
            public string Cabin { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("cabinClass")]
            [Validation(Required=false)]
            public int? CabinClass { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>经济舱</para>
            /// </summary>
            [NameInMap("cabinClassStr")]
            [Validation(Required=false)]
            public string CabinClassStr { get; set; }

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
            /// <para>2021-07-08 15:23:56</para>
            /// </summary>
            [NameInMap("depTime")]
            [Validation(Required=false)]
            public string DepTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.1</para>
            /// </summary>
            [NameInMap("discount")]
            [Validation(Required=false)]
            public double? Discount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MU2759</para>
            /// </summary>
            [NameInMap("flightNo")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

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
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

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
        /// <para>ding1234</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("exceedType")]
        [Validation(Required=false)]
        public int? ExceedType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>经济舱（2折及以下）</para>
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
