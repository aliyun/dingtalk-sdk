// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentUserResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateResidentUserResponseBody body;

    public static UpdateResidentUserResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentUserResponse self = new UpdateResidentUserResponse();
        return TeaModel.build(map, self);
    }

    public UpdateResidentUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateResidentUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateResidentUserResponse setBody(UpdateResidentUserResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateResidentUserResponseBody getBody() {
        return this.body;
    }

}
