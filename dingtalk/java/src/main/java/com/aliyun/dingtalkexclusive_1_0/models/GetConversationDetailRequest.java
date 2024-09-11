// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConversationDetailRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cid123xxx</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    public static GetConversationDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetConversationDetailRequest self = new GetConversationDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetConversationDetailRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

}
