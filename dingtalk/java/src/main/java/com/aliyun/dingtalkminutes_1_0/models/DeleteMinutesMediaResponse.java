// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class DeleteMinutesMediaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteMinutesMediaResponseBody body;

    public static DeleteMinutesMediaResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMinutesMediaResponse self = new DeleteMinutesMediaResponse();
        return TeaModel.build(map, self);
    }

    public DeleteMinutesMediaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteMinutesMediaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteMinutesMediaResponse setBody(DeleteMinutesMediaResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteMinutesMediaResponseBody getBody() {
        return this.body;
    }

}
