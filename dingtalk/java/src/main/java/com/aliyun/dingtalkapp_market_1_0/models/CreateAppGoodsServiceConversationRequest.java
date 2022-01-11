// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class CreateAppGoodsServiceConversationRequest extends TeaModel {
    @NameInMap("isvUserId")
    public String isvUserId;

    @NameInMap("orderId")
    public Long orderId;

    public static CreateAppGoodsServiceConversationRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAppGoodsServiceConversationRequest self = new CreateAppGoodsServiceConversationRequest();
        return TeaModel.build(map, self);
    }

    public CreateAppGoodsServiceConversationRequest setIsvUserId(String isvUserId) {
        this.isvUserId = isvUserId;
        return this;
    }
    public String getIsvUserId() {
        return this.isvUserId;
    }

    public CreateAppGoodsServiceConversationRequest setOrderId(Long orderId) {
        this.orderId = orderId;
        return this;
    }
    public Long getOrderId() {
        return this.orderId;
    }

}
