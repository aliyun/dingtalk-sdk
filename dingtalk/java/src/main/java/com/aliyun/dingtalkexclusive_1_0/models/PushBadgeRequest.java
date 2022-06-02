// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PushBadgeRequest extends TeaModel {
    // 微应用agentId
    @NameInMap("agentId")
    public String agentId;

    // 推送类型
    @NameInMap("pushType")
    public String pushType;

    // 推送的内容（目前仅限数字）
    @NameInMap("pushValue")
    public String pushValue;

    // 员工userId列表
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static PushBadgeRequest build(java.util.Map<String, ?> map) throws Exception {
        PushBadgeRequest self = new PushBadgeRequest();
        return TeaModel.build(map, self);
    }

    public PushBadgeRequest setAgentId(String agentId) {
        this.agentId = agentId;
        return this;
    }
    public String getAgentId() {
        return this.agentId;
    }

    public PushBadgeRequest setPushType(String pushType) {
        this.pushType = pushType;
        return this;
    }
    public String getPushType() {
        return this.pushType;
    }

    public PushBadgeRequest setPushValue(String pushValue) {
        this.pushValue = pushValue;
        return this;
    }
    public String getPushValue() {
        return this.pushValue;
    }

    public PushBadgeRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
