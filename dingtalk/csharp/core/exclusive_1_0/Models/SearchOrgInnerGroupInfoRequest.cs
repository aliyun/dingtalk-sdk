// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SearchOrgInnerGroupInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>创建时间查询最大时间戳</para>
        /// </summary>
        [NameInMap("createTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>创建时间查询最小时间戳</para>
        /// </summary>
        [NameInMap("createTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>群人数范围最大值，例如100</para>
        /// </summary>
        [NameInMap("groupMembersCountEnd")]
        [Validation(Required=false)]
        public int? GroupMembersCountEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>群人数范围最小值，例如1</para>
        /// </summary>
        [NameInMap("groupMembersCountStart")]
        [Validation(Required=false)]
        public int? GroupMembersCountStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>群名称</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>群主userId</para>
        /// </summary>
        [NameInMap("groupOwner")]
        [Validation(Required=false)]
        public string GroupOwner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>最后一次活跃时间戳最大值</para>
        /// </summary>
        [NameInMap("lastActiveTimeEnd")]
        [Validation(Required=false)]
        public long? LastActiveTimeEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>最后一次活跃时间戳最小值</para>
        /// </summary>
        [NameInMap("lastActiveTimeStart")]
        [Validation(Required=false)]
        public long? LastActiveTimeStart { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>当前查询人的userId</para>
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>分页大小，最大不能超过100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>分页号，从1开始</para>
        /// </summary>
        [NameInMap("pageStart")]
        [Validation(Required=false)]
        public int? PageStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>是否同步到钉盘 0不同步 1同步</para>
        /// </summary>
        [NameInMap("syncToDingpan")]
        [Validation(Required=false)]
        public int? SyncToDingpan { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>每次查询唯一标识，保证每次分页查询时该值不变</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
