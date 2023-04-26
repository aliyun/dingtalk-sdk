// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateStoreGroupConversationResponseBody extends TeaModel {
    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("openConversationId")
    public String openConversationId;

    public static CreateStoreGroupConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateStoreGroupConversationResponseBody self = new CreateStoreGroupConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateStoreGroupConversationResponseBody setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public CreateStoreGroupConversationResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
