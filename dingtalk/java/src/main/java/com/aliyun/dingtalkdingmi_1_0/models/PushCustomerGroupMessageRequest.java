// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class PushCustomerGroupMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidxxxx</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

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
