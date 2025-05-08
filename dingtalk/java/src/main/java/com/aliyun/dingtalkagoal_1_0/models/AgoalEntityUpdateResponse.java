// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalEntityUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalEntityUpdateResponseBody body;

    public static AgoalEntityUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalEntityUpdateResponse self = new AgoalEntityUpdateResponse();
        return TeaModel.build(map, self);
    }

    public AgoalEntityUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalEntityUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalEntityUpdateResponse setBody(AgoalEntityUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalEntityUpdateResponseBody getBody() {
        return this.body;
    }

}
