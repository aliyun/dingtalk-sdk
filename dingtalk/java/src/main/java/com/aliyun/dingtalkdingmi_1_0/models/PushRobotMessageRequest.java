// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushRobotMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1234</p>
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
     * <p>123456abc</p>
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
