// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class UpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateResponseBody body;

    public static UpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateResponse self = new UpdateResponse();
        return TeaModel.build(map, self);
    }

    public UpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateResponse setBody(UpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateResponseBody getBody() {
        return this.body;
    }

}
