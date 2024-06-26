// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>CUS_XXXX</p>
     */
    @NameInMap("code")
    public String code;

    public static GetCustomerRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerRequest self = new GetCustomerRequest();
        return TeaModel.build(map, self);
    }

    public GetCustomerRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

}
