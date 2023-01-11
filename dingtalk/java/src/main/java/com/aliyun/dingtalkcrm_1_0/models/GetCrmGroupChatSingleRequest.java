// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatSingleRequest extends TeaModel {
    /**
     * <p>客户群openConversationId</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetCrmGroupChatSingleRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCrmGroupChatSingleRequest self = new GetCrmGroupChatSingleRequest();
        return TeaModel.build(map, self);
    }

    public GetCrmGroupChatSingleRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
