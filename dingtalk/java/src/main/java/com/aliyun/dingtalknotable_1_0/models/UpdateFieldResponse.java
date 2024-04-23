// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class UpdateFieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateFieldResponseBody body;

    public static UpdateFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFieldResponse self = new UpdateFieldResponse();
        return TeaModel.build(map, self);
    }

    public UpdateFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateFieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateFieldResponse setBody(UpdateFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateFieldResponseBody getBody() {
        return this.body;
    }

}
