// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AppendCustomerDataAuthResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    public static AppendCustomerDataAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppendCustomerDataAuthResponseBody self = new AppendCustomerDataAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public AppendCustomerDataAuthResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
