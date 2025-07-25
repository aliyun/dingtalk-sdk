// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class QueryRedeemVipMemberRequest extends TeaModel {
    @NameInMap("bizRequestId")
    public String bizRequestId;

    @NameInMap("channel")
    public String channel;

    @NameInMap("dingtalkId")
    public String dingtalkId;

    @NameInMap("duration")
    public Long duration;

    @NameInMap("mobile")
    public String mobile;

    @NameInMap("uuid")
    public String uuid;

    public static QueryRedeemVipMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryRedeemVipMemberRequest self = new QueryRedeemVipMemberRequest();
        return TeaModel.build(map, self);
    }

    public QueryRedeemVipMemberRequest setBizRequestId(String bizRequestId) {
        this.bizRequestId = bizRequestId;
        return this;
    }
    public String getBizRequestId() {
        return this.bizRequestId;
    }

    public QueryRedeemVipMemberRequest setChannel(String channel) {
        this.channel = channel;
        return this;
    }
    public String getChannel() {
        return this.channel;
    }

    public QueryRedeemVipMemberRequest setDingtalkId(String dingtalkId) {
        this.dingtalkId = dingtalkId;
        return this;
    }
    public String getDingtalkId() {
        return this.dingtalkId;
    }

    public QueryRedeemVipMemberRequest setDuration(Long duration) {
        this.duration = duration;
        return this;
    }
    public Long getDuration() {
        return this.duration;
    }

    public QueryRedeemVipMemberRequest setMobile(String mobile) {
        this.mobile = mobile;
        return this;
    }
    public String getMobile() {
        return this.mobile;
    }

    public QueryRedeemVipMemberRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
