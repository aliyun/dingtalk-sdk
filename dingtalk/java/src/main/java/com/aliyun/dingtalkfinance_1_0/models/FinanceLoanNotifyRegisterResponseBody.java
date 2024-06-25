// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class FinanceLoanNotifyRegisterResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public String result;

    public static FinanceLoanNotifyRegisterResponseBody build(java.util.Map<String, ?> map) throws Exception {
        FinanceLoanNotifyRegisterResponseBody self = new FinanceLoanNotifyRegisterResponseBody();
        return TeaModel.build(map, self);
    }

    public FinanceLoanNotifyRegisterResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public FinanceLoanNotifyRegisterResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
