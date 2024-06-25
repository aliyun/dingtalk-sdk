// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreConversationsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxx店</p>
     */
    @NameInMap("conversationTitle")
    public String conversationTitle;

    /**
     * <strong>example:</strong>
     * <p>store</p>
     */
    @NameInMap("conversationType")
    public String conversationType;

    public static DigitalStoreConversationsRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreConversationsRequest self = new DigitalStoreConversationsRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreConversationsRequest setConversationTitle(String conversationTitle) {
        this.conversationTitle = conversationTitle;
        return this;
    }
    public String getConversationTitle() {
        return this.conversationTitle;
    }

    public DigitalStoreConversationsRequest setConversationType(String conversationType) {
        this.conversationType = conversationType;
        return this;
    }
    public String getConversationType() {
        return this.conversationType;
    }

}
