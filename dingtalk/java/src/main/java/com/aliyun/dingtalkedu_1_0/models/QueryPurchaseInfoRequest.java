// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPurchaseInfoRequest extends TeaModel {
    // 商户id
    @NameInMap("merchantId")
    public String merchantId;

    // 场景
    @NameInMap("scene")
    public Integer scene;

    // 设备序列号
    @NameInMap("sn")
    public String sn;

    // 员工id
    @NameInMap("userId")
    public String userId;

    public static QueryPurchaseInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPurchaseInfoRequest self = new QueryPurchaseInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryPurchaseInfoRequest setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public QueryPurchaseInfoRequest setScene(Integer scene) {
        this.scene = scene;
        return this;
    }
    public Integer getScene() {
        return this.scene;
    }

    public QueryPurchaseInfoRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public QueryPurchaseInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
