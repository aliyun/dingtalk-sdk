// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushCustomerGroupMessageRequest extends TeaModel {
    // 客户群会话id
    @NameInMap("conversationId")
    public String conversationId;

    // 消息类型
    @NameInMap("msgKey")
    public String msgKey;

    // 消息模板替换参数
    @NameInMap("msgParam")
    public String msgParam;

    public static PushCustomerGroupMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        PushCustomerGroupMessageRequest self = new PushCustomerGroupMessageRequest();
        return TeaModel.build(map, self);
    }

    public PushCustomerGroupMessageRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public PushCustomerGroupMessageRequest setMsgKey(String msgKey) {
        this.msgKey = msgKey;
        return this;
    }
    public String getMsgKey() {
        return this.msgKey;
    }

    public PushCustomerGroupMessageRequest setMsgParam(String msgParam) {
        this.msgParam = msgParam;
        return this;
    }
    public String getMsgParam() {
        return this.msgParam;
    }

}
