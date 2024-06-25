// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupSendRequest extends TeaModel {
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

    /**
     * <strong>example:</strong>
     * <p>02feb1cd4ncmed92998723813a6bfa89eea1df91a750721979992870dd90bdfa</p>
     */
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
