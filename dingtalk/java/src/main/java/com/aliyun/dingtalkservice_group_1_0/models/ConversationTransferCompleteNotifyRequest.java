// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ConversationTransferCompleteNotifyRequest extends TeaModel {
    /**
     * <p>小二2088id</p>
     */
    @NameInMap("alipayUserId")
    public String alipayUserId;

    /**
     * <p>DT端会话ID</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    /**
     * <p>小二昵称</p>
     */
    @NameInMap("nickName")
    public String nickName;

    /**
     * <p>开放团队id</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>对应外部渠道的会话ID</p>
     */
    @NameInMap("serviceToken")
    public String serviceToken;

    /**
     * <p>小二id</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>DT端定义的，标识唯一的访</p>
     */
    @NameInMap("visitorToken")
    public String visitorToken;

    public static ConversationTransferCompleteNotifyRequest build(java.util.Map<String, ?> map) throws Exception {
        ConversationTransferCompleteNotifyRequest self = new ConversationTransferCompleteNotifyRequest();
        return TeaModel.build(map, self);
    }

    public ConversationTransferCompleteNotifyRequest setAlipayUserId(String alipayUserId) {
        this.alipayUserId = alipayUserId;
        return this;
    }
    public String getAlipayUserId() {
        return this.alipayUserId;
    }

    public ConversationTransferCompleteNotifyRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public ConversationTransferCompleteNotifyRequest setNickName(String nickName) {
        this.nickName = nickName;
        return this;
    }
    public String getNickName() {
        return this.nickName;
    }

    public ConversationTransferCompleteNotifyRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public ConversationTransferCompleteNotifyRequest setServiceToken(String serviceToken) {
        this.serviceToken = serviceToken;
        return this;
    }
    public String getServiceToken() {
        return this.serviceToken;
    }

    public ConversationTransferCompleteNotifyRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public ConversationTransferCompleteNotifyRequest setVisitorToken(String visitorToken) {
        this.visitorToken = visitorToken;
        return this;
    }
    public String getVisitorToken() {
        return this.visitorToken;
    }

}
