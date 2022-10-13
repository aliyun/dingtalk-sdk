// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class SendRobotMessageRequest extends TeaModel {
    // @人的appuid列表
    @NameInMap("atAppUids")
    public java.util.List<String> atAppUids;

    // @人的手机号列表
    @NameInMap("atMobiles")
    public java.util.List<String> atMobiles;

    // @人的unionid列表
    @NameInMap("atUnionIds")
    public java.util.List<String> atUnionIds;

    // @人的userid列表
    @NameInMap("atUsers")
    public java.util.List<String> atUsers;

    // 租户channel
    @NameInMap("channel")
    public String channel;

    // 是否@所有人。  true：是  false：否
    @NameInMap("isAtAll")
    public Boolean isAtAll;

    // 消息模板内容替换参数，多媒体类型
    @NameInMap("msgMediaIdParamMap")
    public java.util.Map<String, ?> msgMediaIdParamMap;

    // 消息模板内容替换参数，普通文本类型
    @NameInMap("msgParamMap")
    public java.util.Map<String, ?> msgParamMap;

    // 消息模板id
    @NameInMap("msgTemplateId")
    public String msgTemplateId;

    // 消息接收人appuid列表
    @NameInMap("receiverAppUids")
    public java.util.List<String> receiverAppUids;

    // 消息接收人手机号列表
    @NameInMap("receiverMobiles")
    public java.util.List<String> receiverMobiles;

    // 消息接收人unionId列表
    @NameInMap("receiverUnionIds")
    public java.util.List<String> receiverUnionIds;

    // 消息接收人userId列表
    @NameInMap("receiverUserIds")
    public java.util.List<String> receiverUserIds;

    // 用于发送卡片的机器人编码，与场景群模板中的机器人编码保持一致
    @NameInMap("robotCode")
    public String robotCode;

    // 会话id
    @NameInMap("targetOpenConversationId")
    public String targetOpenConversationId;

    public static SendRobotMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        SendRobotMessageRequest self = new SendRobotMessageRequest();
        return TeaModel.build(map, self);
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

    public SendRobotMessageRequest setIsAtAll(Boolean isAtAll) {
        this.isAtAll = isAtAll;
        return this;
    }
    public Boolean getIsAtAll() {
        return this.isAtAll;
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
