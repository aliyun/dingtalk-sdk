// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomerBizTypeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customerBizType")
    public String customerBizType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static UpdateCustomerBizTypeRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomerBizTypeRequest self = new UpdateCustomerBizTypeRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCustomerBizTypeRequest setCustomerBizType(String customerBizType) {
        this.customerBizType = customerBizType;
        return this;
    }
    public String getCustomerBizType() {
        return this.customerBizType;
    }

    public UpdateCustomerBizTypeRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

}
