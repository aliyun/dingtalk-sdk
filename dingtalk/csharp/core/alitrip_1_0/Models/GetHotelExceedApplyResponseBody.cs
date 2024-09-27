// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class GetHotelExceedApplyResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("applyId")]
        [Validation(Required=false)]
        public long? ApplyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("applyIntentionInfoDO")]
        [Validation(Required=false)]
        public GetHotelExceedApplyResponseBodyApplyIntentionInfoDO ApplyIntentionInfoDO { get; set; }
        public class GetHotelExceedApplyResponseBodyApplyIntentionInfoDO : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-08</para>
            /// </summary>
            [NameInMap("checkIn")]
            [Validation(Required=false)]
            public string CheckIn { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-08</para>
            /// </summary>
            [NameInMap("checkOut")]
            [Validation(Required=false)]
            public string CheckOut { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA</para>
            /// </summary>
            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>上海</para>
            /// </summary>
            [NameInMap("cityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("together")]
            [Validation(Required=false)]
            public bool? Together { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
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
        /// <para>16</para>
        /// </summary>
        [NameInMap("exceedType")]
        [Validation(Required=false)]
        public int? ExceedType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210000</para>
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
