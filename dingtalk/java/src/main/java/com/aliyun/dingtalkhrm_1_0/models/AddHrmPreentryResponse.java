// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddHrmPreentryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AddHrmPreentryResponseBody body;

    public static AddHrmPreentryResponse build(java.util.Map<String, ?> map) throws Exception {
        AddHrmPreentryResponse self = new AddHrmPreentryResponse();
        return TeaModel.build(map, self);
    }

    public AddHrmPreentryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddHrmPreentryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddHrmPreentryResponse setBody(AddHrmPreentryResponseBody body) {
        this.body = body;
        return this;
    }
    public AddHrmPreentryResponseBody getBody() {
        return this.body;
    }

}
