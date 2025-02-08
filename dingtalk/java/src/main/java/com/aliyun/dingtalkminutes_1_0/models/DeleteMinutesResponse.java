// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class DeleteMinutesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteMinutesResponseBody body;

    public static DeleteMinutesResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMinutesResponse self = new DeleteMinutesResponse();
        return TeaModel.build(map, self);
    }

    public DeleteMinutesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteMinutesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteMinutesResponse setBody(DeleteMinutesResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteMinutesResponseBody getBody() {
        return this.body;
    }

}
