// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotMessageRequest extends TeaModel {
    /**
     * <p>机器人id</p>
     */
    @NameInMap("chatbotId")
    public String chatbotId;

    /**
     * <p>消息类型</p>
     */
    @NameInMap("msgKey")
    public String msgKey;

    /**
     * <p>消息模板替换参数</p>
     */
    @NameInMap("msgParam")
    public String msgParam;

    /**
     * <p>用户id</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PushIntelligentRobotMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PushIntelligentRobotMessageRequest self = new PushIntelligentRobotMessageRequest();
        return TeaModel.build(map, self);
    }

    public PushIntelligentRobotMessageRequest setChatbotId(String chatbotId) {
        this.chatbotId = chatbotId;
        return this;
    }
    public String getChatbotId() {
        return this.chatbotId;
    }

    public PushIntelligentRobotMessageRequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public PushIntelligentRobotMessageRequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

    public PushIntelligentRobotMessageRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
