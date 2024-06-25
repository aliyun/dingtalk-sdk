// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetSupplierRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUP_XXX</p>
     */
    @NameInMap("code")
    public String code;

    public static GetSupplierRequest build(java.util.Map<String, ?> map) throws Exception {
        GetSupplierRequest self = new GetSupplierRequest();
        return TeaModel.build(map, self);
    }

    public GetSupplierRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
