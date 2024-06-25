// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationCreatedNotifyRequest extends TeaModel {
    @NameInMap("alipayUserId")
    public String alipayUserId;

    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("nickName")
    public String nickName;

    /**
     * <strong>example:</strong>
     * <p>eWaJSqDcLsoiE</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    @NameInMap("serverName")
    public String serverName;

    @NameInMap("serverTips")
    public String serverTips;

    /**
     * <strong>example:</strong>
     * <p>对应外部渠道的会话ID</p>
     */
    @NameInMap("serviceToken")
    public String serviceToken;

    @NameInMap("timeoutRemindTips")
    public String timeoutRemindTips;

    @NameInMap("userId")
    public String userId;

    @NameInMap("visitorToken")
    public String visitorToken;

    public static ConversationCreatedNotifyRequest build(java.util.Map<String, ?> map) throws Exception {
        ConversationCreatedNotifyRequest self = new ConversationCreatedNotifyRequest();
        return TeaModel.build(map, self);
    }

    public ConversationCreatedNotifyRequest setAlipayUserId(String alipayUserId) {
        this.alipayUserId = alipayUserId;
        return this;
    }
    public String getAlipayUserId() {
        return this.alipayUserId;
    }

    public ConversationCreatedNotifyRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public ConversationCreatedNotifyRequest setNickName(String nickName) {
        this.nickName = nickName;
        return this;
    }
    public String getNickName() {
        return this.nickName;
    }

    public ConversationCreatedNotifyRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public ConversationCreatedNotifyRequest setServerName(String serverName) {
        this.serverName = serverName;
        return this;
    }
    public String getServerName() {
        return this.serverName;
    }

    public ConversationCreatedNotifyRequest setServerTips(String serverTips) {
        this.serverTips = serverTips;
        return this;
    }
    public String getServerTips() {
        return this.serverTips;
    }

    public ConversationCreatedNotifyRequest setServiceToken(String serviceToken) {
        this.serviceToken = serviceToken;
        return this;
    }
    public String getServiceToken() {
        return this.serviceToken;
    }

    public ConversationCreatedNotifyRequest setTimeoutRemindTips(String timeoutRemindTips) {
        this.timeoutRemindTips = timeoutRemindTips;
        return this;
    }
    public String getTimeoutRemindTips() {
        return this.timeoutRemindTips;
    }

    public ConversationCreatedNotifyRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public ConversationCreatedNotifyRequest setVisitorToken(String visitorToken) {
        this.visitorToken = visitorToken;
        return this;
    }
    public String getVisitorToken() {
        return this.visitorToken;
    }

}
