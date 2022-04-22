// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationCreatedNotifyRequest extends TeaModel {
    // 小二客服2088
    @NameInMap("alipayUserId")
    public String alipayUserId;

    // DT端会话ID
    @NameInMap("conversationId")
    public String conversationId;

    // 小二客服昵称
    @NameInMap("nickName")
    public String nickName;

    // 开放团队id
    @NameInMap("openTeamId")
    public String openTeamId;

    // 客服名称
    @NameInMap("serverName")
    public String serverName;

    // 客服服务提示
    @NameInMap("serverTips")
    public String serverTips;

    @NameInMap("serviceToken")
    public String serviceToken;

    // 超时规则提示
    @NameInMap("timeoutRemindTips")
    public String timeoutRemindTips;

    // 小二客服id
    @NameInMap("userId")
    public String userId;

    // DT端定义的，标识唯一的访客
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
