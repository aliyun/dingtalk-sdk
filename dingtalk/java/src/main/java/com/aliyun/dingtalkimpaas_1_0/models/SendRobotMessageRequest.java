// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class SendRobotMessageRequest extends TeaModel {
    /**
     * <p>是否@全员</p>
     */
    @NameInMap("atAll")
    public Boolean atAll;

    /**
     * <p>@人的appuid列表</p>
     */
    @NameInMap("atAppUids")
    public java.util.List<String> atAppUids;

    /**
     * <p>@人的手机号列表</p>
     */
    @NameInMap("atMobiles")
    public java.util.List<String> atMobiles;

    /**
     * <p>@人的unionid列表</p>
     */
    @NameInMap("atUnionIds")
    public java.util.List<String> atUnionIds;

    /**
     * <p>@人的userid列表</p>
     */
    @NameInMap("atUsers")
    public java.util.List<String> atUsers;

    /**
     * <p>租户channel</p>
     */
    @NameInMap("channel")
    public String channel;

    /**
     * <p>消息模板内容替换参数，多媒体类型</p>
     */
    @NameInMap("msgMediaIdParamMap")
    public java.util.Map<String, ?> msgMediaIdParamMap;

    /**
     * <p>消息模板内容替换参数，普通文本类型</p>
     */
    @NameInMap("msgParamMap")
    public java.util.Map<String, ?> msgParamMap;

    /**
     * <p>消息模板id</p>
     */
    @NameInMap("msgTemplateId")
    public String msgTemplateId;

    /**
     * <p>消息接收人appuid列表</p>
     */
    @NameInMap("receiverAppUids")
    public java.util.List<String> receiverAppUids;

    /**
     * <p>消息接收人手机号列表</p>
     */
    @NameInMap("receiverMobiles")
    public java.util.List<String> receiverMobiles;

    /**
     * <p>消息接收人unionId列表</p>
     */
    @NameInMap("receiverUnionIds")
    public java.util.List<String> receiverUnionIds;

    /**
     * <p>消息接收人userId列表</p>
     */
    @NameInMap("receiverUserIds")
    public java.util.List<String> receiverUserIds;

    /**
     * <p>用于发送卡片的机器人编码，与场景群模板中的机器人编码保持一致</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <p>会话id</p>
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
