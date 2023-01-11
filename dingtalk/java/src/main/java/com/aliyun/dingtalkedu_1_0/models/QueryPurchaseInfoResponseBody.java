// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPurchaseInfoResponseBody extends TeaModel {
    /**
     * <p>组织id</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>商户id</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>名字</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>场景id</p>
     */
    @NameInMap("scene")
    public Integer scene;

    /**
     * <p>状态</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>员工id</p>
     */
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
