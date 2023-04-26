// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPurchaseInfoResponseBody extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("merchantId")
    public String merchantId;

    @NameInMap("name")
    public String name;

    @NameInMap("scene")
    public Integer scene;

    @NameInMap("status")
    public Integer status;

    @NameInMap("userId")
    public String userId;

    public static QueryPurchaseInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPurchaseInfoResponseBody self = new QueryPurchaseInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPurchaseInfoResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryPurchaseInfoResponseBody setMerchantId(String merchantId) {
        this.merchantId = merchantId;
        return this;
    }
    public String getMerchantId() {
        return this.merchantId;
    }

    public QueryPurchaseInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public QueryPurchaseInfoResponseBody setScene(Integer scene) {
        this.scene = scene;
        return this;
    }
    public Integer getScene() {
        return this.scene;
    }

    public QueryPurchaseInfoResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public QueryPurchaseInfoResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
