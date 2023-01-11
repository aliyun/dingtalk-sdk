// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateCoupleGroupConversationResponseBody extends TeaModel {
    /**
     * <p>钉钉群会话id。</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    /**
     * <p>群会话Id。</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static CreateCoupleGroupConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCoupleGroupConversationResponseBody self = new CreateCoupleGroupConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCoupleGroupConversationResponseBody setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public CreateCoupleGroupConversationResponseBody setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
