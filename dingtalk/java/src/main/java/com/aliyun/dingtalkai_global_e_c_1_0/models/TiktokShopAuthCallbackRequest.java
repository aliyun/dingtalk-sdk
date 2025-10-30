// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class TiktokShopAuthCallbackRequest extends TeaModel {
    @NameInMap("sellerType")
    public String sellerType;

    @NameInMap("shopId")
    public String shopId;

    @NameInMap("shopName")
    public String shopName;

    @NameInMap("shopRegion")
    public String shopRegion;

    public static TiktokShopAuthCallbackRequest build(java.util.Map<String, ?> map) throws Exception {
        TiktokShopAuthCallbackRequest self = new TiktokShopAuthCallbackRequest();
        return TeaModel.build(map, self);
    }

    public TiktokShopAuthCallbackRequest setSellerType(String sellerType) {
        this.sellerType = sellerType;
        return this;
    }
    public String getSellerType() {
        return this.sellerType;
    }

    public TiktokShopAuthCallbackRequest setShopId(String shopId) {
        this.shopId = shopId;
        return this;
    }
    public String getShopId() {
        return this.shopId;
    }

    public TiktokShopAuthCallbackRequest setShopName(String shopName) {
        this.shopName = shopName;
        return this;
    }
    public String getShopName() {
        return this.shopName;
    }

    public TiktokShopAuthCallbackRequest setShopRegion(String shopRegion) {
        this.shopRegion = shopRegion;
        return this;
    }
    public String getShopRegion() {
        return this.shopRegion;
    }

}
