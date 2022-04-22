// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CloseConversationRequest extends TeaModel {
    // DT端会话ID
    @NameInMap("conversationId")
    public String conversationId;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 客户信息
    @NameInMap("serverTips")
    public String serverTips;

    // 对应外部渠道的会话ID
    @NameInMap("serviceToken")
    public String serviceToken;

    // 渠道类型
    @NameInMap("targetChannel")
    public String targetChannel;

    // DT端定义的
    @NameInMap("visitorToken")
    public String visitorToken;

    public static CloseConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseConversationRequest self = new CloseConversationRequest();
        return TeaModel.build(map, self);
    }

    public CloseConversationRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public CloseConversationRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CloseConversationRequest setServerTips(String serverTips) {
        this.serverTips = serverTips;
        return this;
    }
    public String getServerTips() {
        return this.serverTips;
    }

    public CloseConversationRequest setServiceToken(String serviceToken) {
        this.serviceToken = serviceToken;
        return this;
    }
    public String getServiceToken() {
        return this.serviceToken;
    }

    public CloseConversationRequest setTargetChannel(String targetChannel) {
        this.targetChannel = targetChannel;
        return this;
    }
    public String getTargetChannel() {
        return this.targetChannel;
    }

    public CloseConversationRequest setVisitorToken(String visitorToken) {
        this.visitorToken = visitorToken;
        return this;
    }
    public String getVisitorToken() {
        return this.visitorToken;
    }

}
