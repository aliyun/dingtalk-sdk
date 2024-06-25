// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class SendRobotMessageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("atAll")
    public Boolean atAll;

    @NameInMap("atAppUids")
    public java.util.List<String> atAppUids;

    @NameInMap("atMobiles")
    public java.util.List<String> atMobiles;

    @NameInMap("atUnionIds")
    public java.util.List<String> atUnionIds;

    @NameInMap("atUsers")
    public java.util.List<String> atUsers;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("channel")
    public String channel;

    /**
     * <strong>example:</strong>
     * <p>{&quot;pic1&quot;:&quot;@123&quot;,&quot;pic2&quot;:&quot;@456&quot;}</p>
     */
    @NameInMap("msgMediaIdParamMap")
    public java.util.Map<String, ?> msgMediaIdParamMap;

    /**
     * <strong>example:</strong>
     * <p>{&quot;text1&quot;:&quot;hello&quot;,&quot;text2&quot;:&quot;world&quot;}</p>
     */
    @NameInMap("msgParamMap")
    public java.util.Map<String, ?> msgParamMap;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("msgTemplateId")
    public String msgTemplateId;

    @NameInMap("receiverAppUids")
    public java.util.List<String> receiverAppUids;

    @NameInMap("receiverMobiles")
    public java.util.List<String> receiverMobiles;

    @NameInMap("receiverUnionIds")
    public java.util.List<String> receiverUnionIds;

    @NameInMap("receiverUserIds")
    public java.util.List<String> receiverUserIds;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <strong>example:</strong>
     * <p>123</p>
     */
    @NameInMap("targetOpenConversationId")
    public String targetOpenConversationId;

    public static SendRobotMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendRobotMessageRequest self = new SendRobotMessageRequest();
        return TeaModel.build(map, self);
    }

    public SendRobotMessageRequest setAtAll(Boolean atAll) {
        this.atAll = atAll;
        return this;
    }
    public Boolean getAtAll() {
        return this.atAll;
    }

    public SendRobotMessageRequest setAtAppUids(java.util.List<String> atAppUids) {
        this.atAppUids = atAppUids;
        return this;
    }
    public java.util.List<String> getAtAppUids() {
        return this.atAppUids;
    }

    public SendRobotMessageRequest setAtMobiles(java.util.List<String> atMobiles) {
        this.atMobiles = atMobiles;
        return this;
    }
    public java.util.List<String> getAtMobiles() {
        return this.atMobiles;
    }

    public SendRobotMessageRequest setAtUnionIds(java.util.List<String> atUnionIds) {
        this.atUnionIds = atUnionIds;
        return this;
    }
    public java.util.List<String> getAtUnionIds() {
        return this.atUnionIds;
    }

    public SendRobotMessageRequest setAtUsers(java.util.List<String> atUsers) {
        this.atUsers = atUsers;
        return this;
    }
    public java.util.List<String> getAtUsers() {
        return this.atUsers;
    }

    public SendRobotMessageRequest setChannel(String channel) {
        this.channel = channel;
        return this;
    }
    public String getChannel() {
        return this.channel;
    }

    public SendRobotMessageRequest setMsgMediaIdParamMap(java.util.Map<String, ?> msgMediaIdParamMap) {
        this.msgMediaIdParamMap = msgMediaIdParamMap;
        return this;
    }
    public java.util.Map<String, ?> getMsgMediaIdParamMap() {
        return this.msgMediaIdParamMap;
    }

    public SendRobotMessageRequest setMsgParamMap(java.util.Map<String, ?> msgParamMap) {
        this.msgParamMap = msgParamMap;
        return this;
    }
    public java.util.Map<String, ?> getMsgParamMap() {
        return this.msgParamMap;
    }

    public SendRobotMessageRequest setMsgTemplateId(String msgTemplateId) {
        this.msgTemplateId = msgTemplateId;
        return this;
    }
    public String getMsgTemplateId() {
        return this.msgTemplateId;
    }

    public SendRobotMessageRequest setReceiverAppUids(java.util.List<String> receiverAppUids) {
        this.receiverAppUids = receiverAppUids;
        return this;
    }
    public java.util.List<String> getReceiverAppUids() {
        return this.receiverAppUids;
    }

    public SendRobotMessageRequest setReceiverMobiles(java.util.List<String> receiverMobiles) {
        this.receiverMobiles = receiverMobiles;
        return this;
    }
    public java.util.List<String> getReceiverMobiles() {
        return this.receiverMobiles;
    }

    public SendRobotMessageRequest setReceiverUnionIds(java.util.List<String> receiverUnionIds) {
        this.receiverUnionIds = receiverUnionIds;
        return this;
    }
    public java.util.List<String> getReceiverUnionIds() {
        return this.receiverUnionIds;
    }

    public SendRobotMessageRequest setReceiverUserIds(java.util.List<String> receiverUserIds) {
        this.receiverUserIds = receiverUserIds;
        return this;
    }
    public java.util.List<String> getReceiverUserIds() {
        return this.receiverUserIds;
    }

    public SendRobotMessageRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public SendRobotMessageRequest setTargetOpenConversationId(String targetOpenConversationId) {
        this.targetOpenConversationId = targetOpenConversationId;
        return this;
    }
    public String getTargetOpenConversationId() {
        return this.targetOpenConversationId;
    }

}
