// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class UpdateFinanceMultiCompanyInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateFinanceMultiCompanyInfoResponseBody body;

    public static UpdateFinanceMultiCompanyInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFinanceMultiCompanyInfoResponse self = new UpdateFinanceMultiCompanyInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateFinanceMultiCompanyInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateFinanceMultiCompanyInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateFinanceMultiCompanyInfoResponse setBody(UpdateFinanceMultiCompanyInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateFinanceMultiCompanyInfoResponseBody getBody() {
        return this.body;
    }

}
