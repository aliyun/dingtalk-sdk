// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CheckEsignFileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CheckEsignFileResponseBody body;

    public static CheckEsignFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CheckEsignFileResponse self = new CheckEsignFileResponse();
        return TeaModel.build(map, self);
    }

    public CheckEsignFileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CheckEsignFileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CheckEsignFileResponse setBody(CheckEsignFileResponseBody body) {
        this.body = body;
        return this;
    }
    public CheckEsignFileResponseBody getBody() {
        return this.body;
    }

}
