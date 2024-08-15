// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalCreateProgressResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalCreateProgressResponseBody body;

    public static AgoalCreateProgressResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalCreateProgressResponse self = new AgoalCreateProgressResponse();
        return TeaModel.build(map, self);
    }

    public AgoalCreateProgressResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalCreateProgressResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalCreateProgressResponse setBody(AgoalCreateProgressResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalCreateProgressResponseBody getBody() {
        return this.body;
    }

}
