// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupSendRequest extends TeaModel {
    // 酷应用的code
    @NameInMap("coolAppCode")
    public String coolAppCode;

    // 消息类型的key
    @NameInMap("msgKey")
    public String msgKey;

    // 消息体
    @NameInMap("msgParam")
    public String msgParam;

    // 开放的群id
    @NameInMap("openConversationId")
    public String openConversationId;

    // 群内机器人的code
    @NameInMap("robotCode")
    public String robotCode;

    // 群内机器人的webhook中的Token
    @NameInMap("token")
    public String token;

    public static OrgGroupSendRequest build(java.util.Map<String, ?> map) throws Exception {
        OrgGroupSendRequest self = new OrgGroupSendRequest();
        return TeaModel.build(map, self);
    }

    public OrgGroupSendRequest setCoolAppCode(String coolAppCode) {
        this.coolAppCode = coolAppCode;
        return this;
    }
    public String getCoolAppCode() {
        return this.coolAppCode;
    }

    public OrgGroupSendRequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public OrgGroupSendRequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

    public OrgGroupSendRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public OrgGroupSendRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public OrgGroupSendRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
