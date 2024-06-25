// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetProductRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROD-xxx</p>
     */
    @NameInMap("code")
    public String code;

    public static GetProductRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProductRequest self = new GetProductRequest();
        return TeaModel.build(map, self);
    }

    public GetProductRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
