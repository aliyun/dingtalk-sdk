// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotMessageRequest extends TeaModel {
    // 企业corpId
    @NameInMap("dingCorpId")
    public String dingCorpId;

    // 机器人id
    @NameInMap("chatbotId")
    public String chatbotId;

    // 用户id
    @NameInMap("userId")
    public String userId;

    // 消息类型
    @NameInMap("msgKey")
    public String msgKey;

    // 消息模板替换参数
    @NameInMap("msgParam")
    public String msgParam;

    public static PushIntelligentRobotMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PushIntelligentRobotMessageRequest self = new PushIntelligentRobotMessageRequest();
        return TeaModel.build(map, self);
    }

    public PushIntelligentRobotMessageRequest setDingCorpId(String dingCorpId) {
        this.dingCorpId = dingCorpId;
        return this;
    }
    public String getDingCorpId() {
        return this.dingCorpId;
    }

    public PushIntelligentRobotMessageRequest setChatbotId(String chatbotId) {
        this.chatbotId = chatbotId;
        return this;
    }
    public String getChatbotId() {
        return this.chatbotId;
    }

    public PushIntelligentRobotMessageRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
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

}
