// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customerId")
    public String customerId;

    public static GetCustomerInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerInfoRequest self = new GetCustomerInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetCustomerInfoRequest setCustomerId(String customerId) {
        this.customerId = customerId;
        return this;
    }
    public String getCustomerId() {
        return this.customerId;
    }

}
