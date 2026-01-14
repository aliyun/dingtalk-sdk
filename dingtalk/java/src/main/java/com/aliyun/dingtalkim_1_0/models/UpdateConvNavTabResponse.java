// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateConvNavTabResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateConvNavTabResponseBody body;

    public static UpdateConvNavTabResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateConvNavTabResponse self = new UpdateConvNavTabResponse();
        return TeaModel.build(map, self);
    }

    public UpdateConvNavTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateConvNavTabResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateConvNavTabResponse setBody(UpdateConvNavTabResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateConvNavTabResponseBody getBody() {
        return this.body;
    }

}
