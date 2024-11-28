// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCidsByBotCodeResponseBody extends TeaModel {
    @NameInMap("openConversationIds")
    public java.util.List<String> openConversationIds;

    public static GetCidsByBotCodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCidsByBotCodeResponseBody self = new GetCidsByBotCodeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCidsByBotCodeResponseBody setOpenConversationIds(java.util.List<String> openConversationIds) {
        this.openConversationIds = openConversationIds;
        return this;
    }
    public java.util.List<String> getOpenConversationIds() {
        return this.openConversationIds;
    }

}
