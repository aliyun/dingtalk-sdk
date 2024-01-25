// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceCompanyInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateFinanceCompanyInfoResponseBody body;

    public static UpdateFinanceCompanyInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFinanceCompanyInfoResponse self = new UpdateFinanceCompanyInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateFinanceCompanyInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateFinanceCompanyInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateFinanceCompanyInfoResponse setBody(UpdateFinanceCompanyInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateFinanceCompanyInfoResponseBody getBody() {
        return this.body;
    }

}
