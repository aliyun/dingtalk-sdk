// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class UpdateInstanceOrderInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateInstanceOrderInfoResponseBody body;

    public static UpdateInstanceOrderInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateInstanceOrderInfoResponse self = new UpdateInstanceOrderInfoResponse();
        return TeaModel.build(map, self);
    }

    public UpdateInstanceOrderInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateInstanceOrderInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateInstanceOrderInfoResponse setBody(UpdateInstanceOrderInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateInstanceOrderInfoResponseBody getBody() {
        return this.body;
    }

}
