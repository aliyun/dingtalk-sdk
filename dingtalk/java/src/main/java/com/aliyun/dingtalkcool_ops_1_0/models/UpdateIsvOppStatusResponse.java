// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_ops_1_0.models;

import com.aliyun.tea.*;

public class UpdateIsvOppStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateIsvOppStatusResponseBody body;

    public static UpdateIsvOppStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateIsvOppStatusResponse self = new UpdateIsvOppStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateIsvOppStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateIsvOppStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateIsvOppStatusResponse setBody(UpdateIsvOppStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateIsvOppStatusResponseBody getBody() {
        return this.body;
    }

}
