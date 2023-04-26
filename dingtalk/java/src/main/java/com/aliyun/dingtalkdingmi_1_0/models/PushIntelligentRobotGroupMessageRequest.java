// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotGroupMessageRequest extends TeaModel {
    @NameInMap("chatbotId")
    public String chatbotId;

    @NameInMap("msgKey")
    public String msgKey;

    @NameInMap("msgParam")
    public String msgParam;

    @NameInMap("openConversationId")
    public String openConversationId;

    public static PushIntelligentRobotGroupMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PushIntelligentRobotGroupMessageRequest self = new PushIntelligentRobotGroupMessageRequest();
        return TeaModel.build(map, self);
    }

    public PushIntelligentRobotGroupMessageRequest setChatbotId(String chatbotId) {
        this.chatbotId = chatbotId;
        return this;
    }
    public String getChatbotId() {
        return this.chatbotId;
    }

    public PushIntelligentRobotGroupMessageRequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public PushIntelligentRobotGroupMessageRequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

    public PushIntelligentRobotGroupMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
