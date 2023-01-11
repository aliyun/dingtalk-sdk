// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushRobotMessageRequest extends TeaModel {
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

    public static PushRobotMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PushRobotMessageRequest self = new PushRobotMessageRequest();
        return TeaModel.build(map, self);
    }

    public PushRobotMessageRequest setChatbotId(String chatbotId) {
        this.chatbotId = chatbotId;
        return this;
    }
    public String getChatbotId() {
        return this.chatbotId;
    }

    public PushRobotMessageRequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public PushRobotMessageRequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

    public PushRobotMessageRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
