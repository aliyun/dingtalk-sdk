// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreStoreInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>余杭塘路xxxx号</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9:00-22:00</para>
        /// </summary>
        [NameInMap("businessHours")]
        [Validation(Required=false)]
        public string BusinessHours { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64266411</para>
        /// </summary>
        [NameInMap("dingDeptId")]
        [Validation(Required=false)]
        public long? DingDeptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>余杭塘路xxxx号</para>
        /// </summary>
        [NameInMap("locationAddress")]
        [Validation(Required=false)]
        public string LocationAddress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>华夏之心店</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>873366531</para>
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOSED</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10平方米</para>
        /// </summary>
        [NameInMap("storeAcreage")]
        [Validation(Required=false)]
        public string StoreAcreage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1千兆</para>
        /// </summary>
        [NameInMap("storeBandwidth")]
        [Validation(Required=false)]
        public string StoreBandwidth { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("storeCode")]
        [Validation(Required=false)]
        public string StoreCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6756433</para>
        /// </summary>
        [NameInMap("storeId")]
        [Validation(Required=false)]
        public long? StoreId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571-123456</para>
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
