// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushOfficialAccountMessageRequest extends TeaModel {
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
     * <p>用户id(在服务窗对应虚拟企业中的用户id)</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PushOfficialAccountMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PushOfficialAccountMessageRequest self = new PushOfficialAccountMessageRequest();
        return TeaModel.build(map, self);
    }

    public PushOfficialAccountMessageRequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public PushOfficialAccountMessageRequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

    public PushOfficialAccountMessageRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
