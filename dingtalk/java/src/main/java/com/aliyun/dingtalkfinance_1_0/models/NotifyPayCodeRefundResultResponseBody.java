// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class NotifyPayCodeRefundResultResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("result")
    public String result;

    public static NotifyPayCodeRefundResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        NotifyPayCodeRefundResultResponseBody self = new NotifyPayCodeRefundResultResponseBody();
        return TeaModel.build(map, self);
    }

    public NotifyPayCodeRefundResultResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
