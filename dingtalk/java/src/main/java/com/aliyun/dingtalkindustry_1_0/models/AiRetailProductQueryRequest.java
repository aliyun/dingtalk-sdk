// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductQueryRequest extends TeaModel {
    @NameInMap("productCode")
    public String productCode;

    @NameInMap("productId")
    public Long productId;

    public static AiRetailProductQueryRequest build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductQueryRequest self = new AiRetailProductQueryRequest();
        return TeaModel.build(map, self);
    }

    public AiRetailProductQueryRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public AiRetailProductQueryRequest setProductId(Long productId) {
        this.productId = productId;
        return this;
    }
    public Long getProductId() {
        return this.productId;
    }

}
