// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateClientServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateClientServiceResponseBody body;

    public static UpdateClientServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateClientServiceResponse self = new UpdateClientServiceResponse();
        return TeaModel.build(map, self);
    }

    public UpdateClientServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateClientServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateClientServiceResponse setBody(UpdateClientServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateClientServiceResponseBody getBody() {
        return this.body;
    }

}
