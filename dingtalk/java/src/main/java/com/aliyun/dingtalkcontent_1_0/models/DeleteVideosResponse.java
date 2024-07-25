// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class DeleteVideosResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteVideosResponseBody body;

    public static DeleteVideosResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteVideosResponse self = new DeleteVideosResponse();
        return TeaModel.build(map, self);
    }

    public DeleteVideosResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteVideosResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteVideosResponse setBody(DeleteVideosResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteVideosResponseBody getBody() {
        return this.body;
    }

}
