// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CheckVoucherStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckVoucherStatusResponseBody body;

    public static CheckVoucherStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckVoucherStatusResponse self = new CheckVoucherStatusResponse();
        return TeaModel.build(map, self);
    }

    public CheckVoucherStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckVoucherStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckVoucherStatusResponse setBody(CheckVoucherStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckVoucherStatusResponseBody getBody() {
        return this.body;
    }

}
