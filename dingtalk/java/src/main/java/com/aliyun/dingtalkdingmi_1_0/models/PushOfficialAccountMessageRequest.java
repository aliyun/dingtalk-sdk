// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushOfficialAccountMessageRequest extends TeaModel {
    @NameInMap("msgKey")
    public String msgKey;

    @NameInMap("msgParam")
    public String msgParam;

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
