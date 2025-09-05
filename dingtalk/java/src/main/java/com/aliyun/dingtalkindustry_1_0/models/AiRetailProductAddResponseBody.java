// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class AiRetailProductAddResponseBody extends TeaModel {
    @NameInMap("productId")
    public Long productId;

    public static AiRetailProductAddResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AiRetailProductAddResponseBody self = new AiRetailProductAddResponseBody();
        return TeaModel.build(map, self);
    }

    public AiRetailProductAddResponseBody setProductId(Long productId) {
        this.productId = productId;
        return this;
    }
    public Long getProductId() {
        return this.productId;
    }

}
