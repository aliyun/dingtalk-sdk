// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetInAppPurchaseGoodsRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static GetInAppPurchaseGoodsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetInAppPurchaseGoodsRequest self = new GetInAppPurchaseGoodsRequest();
        return TeaModel.build(map, self);
    }

    public GetInAppPurchaseGoodsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
