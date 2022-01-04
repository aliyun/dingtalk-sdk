// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CreateSubInstitutionResponseBody extends TeaModel {
    // 进件申请单号
    @NameInMap("orderId")
    public String orderId;

    public static CreateSubInstitutionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSubInstitutionResponseBody self = new CreateSubInstitutionResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSubInstitutionResponseBody setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

}
