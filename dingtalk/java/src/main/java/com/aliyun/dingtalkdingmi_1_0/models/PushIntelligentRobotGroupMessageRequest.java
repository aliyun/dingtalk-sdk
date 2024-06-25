// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushIntelligentRobotGroupMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>abcd1234</p>
     */
    @NameInMap("chatbotId")
    public String chatbotId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sampleText</p>
     */
    @NameInMap("msgKey")
    public String msgKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>eyJjb250ZW50IjogIua1i+ivleWGheWuuSJ9(即{&quot;content&quot;: &quot;测试内容&quot;}的base64编码值)</p>
     */
    @NameInMap("msgParam")
    public String msgParam;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxx</p>
     */
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
