// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class BindCompanyAccountantBookResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BindCompanyAccountantBookResponseBody body;

    public static BindCompanyAccountantBookResponse build(java.util.Map<String, ?> map) throws Exception {
        BindCompanyAccountantBookResponse self = new BindCompanyAccountantBookResponse();
        return TeaModel.build(map, self);
    }

    public BindCompanyAccountantBookResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BindCompanyAccountantBookResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BindCompanyAccountantBookResponse setBody(BindCompanyAccountantBookResponseBody body) {
        this.body = body;
        return this;
    }
    public BindCompanyAccountantBookResponseBody getBody() {
        return this.body;
    }

}
