// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateClassGroupCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateClassGroupCardResponseBody body;

    public static UpdateClassGroupCardResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateClassGroupCardResponse self = new UpdateClassGroupCardResponse();
        return TeaModel.build(map, self);
    }

    public UpdateClassGroupCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateClassGroupCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateClassGroupCardResponse setBody(UpdateClassGroupCardResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateClassGroupCardResponseBody getBody() {
        return this.body;
    }

}
