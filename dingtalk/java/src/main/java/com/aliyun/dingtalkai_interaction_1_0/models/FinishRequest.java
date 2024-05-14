// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class FinishRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("conversationToken")
    public String conversationToken;

    public static FinishRequest build(java.util.Map<String, ?> map) throws Exception {
        FinishRequest self = new FinishRequest();
        return TeaModel.build(map, self);
    }

    public FinishRequest setConversationToken(String conversationToken) {
        this.conversationToken = conversationToken;
        return this;
    }
    public String getConversationToken() {
        return this.conversationToken;
    }

}
