// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateIsvCardMessageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateIsvCardMessageResponseBody body;

    public static UpdateIsvCardMessageResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateIsvCardMessageResponse self = new UpdateIsvCardMessageResponse();
        return TeaModel.build(map, self);
    }

    public UpdateIsvCardMessageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateIsvCardMessageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateIsvCardMessageResponse setBody(UpdateIsvCardMessageResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateIsvCardMessageResponseBody getBody() {
        return this.body;
    }

}
