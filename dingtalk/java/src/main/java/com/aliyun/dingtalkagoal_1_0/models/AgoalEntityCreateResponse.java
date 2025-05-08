// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalEntityCreateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalEntityCreateResponseBody body;

    public static AgoalEntityCreateResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalEntityCreateResponse self = new AgoalEntityCreateResponse();
        return TeaModel.build(map, self);
    }

    public AgoalEntityCreateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalEntityCreateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalEntityCreateResponse setBody(AgoalEntityCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalEntityCreateResponseBody getBody() {
        return this.body;
    }

}
