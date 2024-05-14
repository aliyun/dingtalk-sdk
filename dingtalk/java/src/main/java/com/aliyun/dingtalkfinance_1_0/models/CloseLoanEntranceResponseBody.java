// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class CloseLoanEntranceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public String result;

    public static CloseLoanEntranceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CloseLoanEntranceResponseBody self = new CloseLoanEntranceResponseBody();
        return TeaModel.build(map, self);
    }

    public CloseLoanEntranceResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CloseLoanEntranceResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
