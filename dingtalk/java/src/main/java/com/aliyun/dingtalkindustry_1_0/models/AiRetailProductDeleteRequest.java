// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductDeleteRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>111111</p>
     */
    @NameInMap("productId")
    public Long productId;

    public static AiRetailProductDeleteRequest build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductDeleteRequest self = new AiRetailProductDeleteRequest();
        return TeaModel.build(map, self);
    }

    public AiRetailProductDeleteRequest setProductId(Long productId) {
        this.productId = productId;
        return this;
    }
    public Long getProductId() {
        return this.productId;
    }

}
