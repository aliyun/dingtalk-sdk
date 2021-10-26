// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetSupplierRequest extends TeaModel {
    // 供应商code
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
