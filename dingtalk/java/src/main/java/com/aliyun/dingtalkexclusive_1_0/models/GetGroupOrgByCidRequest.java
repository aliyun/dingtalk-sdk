// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupOrgByCidRequest extends TeaModel {
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetGroupOrgByCidRequest build(java.util.Map<String, ?> map) throws Exception {
        GetGroupOrgByCidRequest self = new GetGroupOrgByCidRequest();
        return TeaModel.build(map, self);
    }

    public GetGroupOrgByCidRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
