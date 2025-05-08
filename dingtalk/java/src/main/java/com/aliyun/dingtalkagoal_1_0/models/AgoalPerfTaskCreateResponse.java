// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPerfTaskCreateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalPerfTaskCreateResponseBody body;

    public static AgoalPerfTaskCreateResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalPerfTaskCreateResponse self = new AgoalPerfTaskCreateResponse();
        return TeaModel.build(map, self);
    }

    public AgoalPerfTaskCreateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalPerfTaskCreateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalPerfTaskCreateResponse setBody(AgoalPerfTaskCreateResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalPerfTaskCreateResponseBody getBody() {
        return this.body;
    }

}
