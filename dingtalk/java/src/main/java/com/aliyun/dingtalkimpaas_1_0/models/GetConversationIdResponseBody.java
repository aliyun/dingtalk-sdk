// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class GetConversationIdResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    public static GetConversationIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetConversationIdResponseBody self = new GetConversationIdResponseBody();
        return TeaModel.build(map, self);
    }

    public GetConversationIdResponseBody setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

}
