// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class CreateAppGoodsServiceConversationResponseBody extends TeaModel {
    // 群名称
    @NameInMap("conversationName")
    public String conversationName;

    // 是否是新群
    @NameInMap("newConversation")
    public Boolean newConversation;

    public static CreateAppGoodsServiceConversationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateAppGoodsServiceConversationResponseBody self = new CreateAppGoodsServiceConversationResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateAppGoodsServiceConversationResponseBody setConversationName(String conversationName) {
        this.conversationName = conversationName;
        return this;
    }
    public String getConversationName() {
        return this.conversationName;
    }

    public CreateAppGoodsServiceConversationResponseBody setNewConversation(Boolean newConversation) {
        this.newConversation = newConversation;
        return this;
    }
    public Boolean getNewConversation() {
        return this.newConversation;
    }

}
