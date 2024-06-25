// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ModifySubInstitutionResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>202110110000001</p>
     */
    @NameInMap("orderId")
    public String orderId;

    public static ModifySubInstitutionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ModifySubInstitutionResponseBody self = new ModifySubInstitutionResponseBody();
        return TeaModel.build(map, self);
    }

    public ModifySubInstitutionResponseBody setOrderId(String orderId) {
        this.orderId = orderId;
        return this;
    }
    public String getOrderId() {
        return this.orderId;
    }

}
