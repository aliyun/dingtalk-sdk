// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupInfoByCidRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetGroupInfoByCidRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGroupInfoByCidRequest self = new GetGroupInfoByCidRequest();
        return TeaModel.build(map, self);
    }

    public GetGroupInfoByCidRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
