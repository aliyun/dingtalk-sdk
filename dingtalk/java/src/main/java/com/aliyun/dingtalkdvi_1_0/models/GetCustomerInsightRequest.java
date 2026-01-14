// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetCustomerInsightRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customerId")
    public String customerId;

    public static GetCustomerInsightRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCustomerInsightRequest self = new GetCustomerInsightRequest();
        return TeaModel.build(map, self);
    }

    public GetCustomerInsightRequest setCustomerId(String customerId) {
        this.customerId = customerId;
        return this;
    }
    public String getCustomerId() {
        return this.customerId;
    }

}
