// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class PrivateChatSendRequest extends TeaModel {
    /**
     * <p>酷应用的code</p>
     */
    @NameInMap("coolAppCode")
    public String coolAppCode;

    /**
     * <p>消息类型的key</p>
     */
    @NameInMap("msgKey")
    public String msgKey;

    /**
     * <p>消息体</p>
     */
    @NameInMap("msgParam")
    public String msgParam;

    /**
     * <p>开放会话ID</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>机器人robotCode</p>
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
