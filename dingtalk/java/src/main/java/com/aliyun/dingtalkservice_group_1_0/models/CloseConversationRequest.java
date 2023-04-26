// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CloseConversationRequest extends TeaModel {
    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("serverTips")
    public String serverTips;

    @NameInMap("serviceToken")
    public String serviceToken;

    @NameInMap("targetChannel")
    public String targetChannel;

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
