// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPurchaseInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dingding123</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>300001</p>
     */
    @NameInMap("merchantId")
    public String merchantId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>小明</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1视频通话</p>
     */
    @NameInMap("scene")
    public Integer scene;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10、已订购；11、未订购（包含已过期）；12、取消</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>200001</p>
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
