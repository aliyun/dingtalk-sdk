// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class OverrideUpdateCustomerDataAuthResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static OverrideUpdateCustomerDataAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OverrideUpdateCustomerDataAuthResponseBody self = new OverrideUpdateCustomerDataAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public OverrideUpdateCustomerDataAuthResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
