// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreQueryConversationResponseBody extends TeaModel {
    @NameInMap("conversationTitle")
    public String conversationTitle;

    @NameInMap("openConversationId")
    public String openConversationId;

    public static DigitalStoreQueryConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreQueryConversationResponseBody self = new DigitalStoreQueryConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public DigitalStoreQueryConversationResponseBody setConversationTitle(String conversationTitle) {
        this.conversationTitle = conversationTitle;
        return this;
    }
    public String getConversationTitle() {
        return this.conversationTitle;
    }

    public DigitalStoreQueryConversationResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
