// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateCustomerResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>CUS_xxxxxx</p>
     */
    @NameInMap("customerCode")
    public String customerCode;

    public static CreateCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateCustomerResponseBody self = new CreateCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateCustomerResponseBody setCustomerCode(String customerCode) {
        this.customerCode = customerCode;
        return this;
    }
    public String getCustomerCode() {
        return this.customerCode;
    }

}
