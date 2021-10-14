// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotGroupMessageRequest extends TeaModel {
    // 企业corpId
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // 机器人id
    @NameInMap("chatbotId")
    public String chatbotId;

    // 群对话id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 消息类型
    @NameInMap("msgKey")
    public String msgKey;

    // 消息模板替换参数
    @NameInMap("msgParam")
    public String msgParam;

    public static PushIntelligentRobotGroupMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PushIntelligentRobotGroupMessageRequest self = new PushIntelligentRobotGroupMessageRequest();
        return TeaModel.build(map, self);
    }

    public PushIntelligentRobotGroupMessageRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public PushIntelligentRobotGroupMessageRequest setChatbotId(String chatbotId) {
        this.chatbotId = chatbotId;
        return this;
    }
    public String getChatbotId() {
        return this.chatbotId;
    }

    public PushIntelligentRobotGroupMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
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

}
