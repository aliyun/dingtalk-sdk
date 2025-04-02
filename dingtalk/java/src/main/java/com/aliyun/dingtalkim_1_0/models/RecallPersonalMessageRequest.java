// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RecallPersonalMessageRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>cidxxxx3451=</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <strong>example:</strong>
     * <p>msgxxx112</p>
     */
    @NameInMap("openMessageId")
    public String openMessageId;

    public static RecallPersonalMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        RecallPersonalMessageRequest self = new RecallPersonalMessageRequest();
        return TeaModel.build(map, self);
    }

    public RecallPersonalMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public RecallPersonalMessageRequest setOpenMessageId(String openMessageId) {
        this.openMessageId = openMessageId;
        return this;
    }
    public String getOpenMessageId() {
        return this.openMessageId;
    }

}
