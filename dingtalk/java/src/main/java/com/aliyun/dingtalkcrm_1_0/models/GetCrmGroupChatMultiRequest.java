// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatMultiRequest extends TeaModel {
    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    public static GetCrmGroupChatMultiRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCrmGroupChatMultiRequest self = new GetCrmGroupChatMultiRequest();
        return TeaModel.build(map, self);
    }

    public GetCrmGroupChatMultiRequest setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

}
