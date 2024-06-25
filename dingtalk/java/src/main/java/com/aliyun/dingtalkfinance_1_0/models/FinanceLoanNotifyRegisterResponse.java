// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class FinanceLoanNotifyRegisterResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FinanceLoanNotifyRegisterResponseBody body;

    public static FinanceLoanNotifyRegisterResponse build(java.util.Map<String, ?> map) throws Exception {
        FinanceLoanNotifyRegisterResponse self = new FinanceLoanNotifyRegisterResponse();
        return TeaModel.build(map, self);
    }

    public FinanceLoanNotifyRegisterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FinanceLoanNotifyRegisterResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FinanceLoanNotifyRegisterResponse setBody(FinanceLoanNotifyRegisterResponseBody body) {
        this.body = body;
        return this;
    }
    public FinanceLoanNotifyRegisterResponseBody getBody() {
        return this.body;
    }

}
