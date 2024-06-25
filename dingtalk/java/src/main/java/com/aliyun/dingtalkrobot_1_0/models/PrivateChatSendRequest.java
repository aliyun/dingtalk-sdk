// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatSendRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>COOLAPP-1-10182EEDD1AC0BA600D9000J</p>
     */
    @NameInMap("coolAppCode")
    public String coolAppCode;

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
     * <p>{&quot;content&quot;:&quot;今天吃肘子&quot;}</p>
     */
    @NameInMap("msgParam")
    public String msgParam;

    /**
     * <strong>example:</strong>
     * <p>cid6KeBBLoveMJOGXoYKF5x7EeiodoA==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>dingue4kfzdxbyn0pjqd</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static PrivateChatSendRequest build(java.util.Map<String, ?> map) throws Exception {
        PrivateChatSendRequest self = new PrivateChatSendRequest();
        return TeaModel.build(map, self);
    }

    public PrivateChatSendRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public PrivateChatSendRequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public PrivateChatSendRequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

    public PrivateChatSendRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public PrivateChatSendRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
