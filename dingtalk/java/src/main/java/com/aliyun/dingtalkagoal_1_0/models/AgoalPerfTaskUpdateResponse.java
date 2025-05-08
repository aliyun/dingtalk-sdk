// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPerfTaskUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalPerfTaskUpdateResponseBody body;

    public static AgoalPerfTaskUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalPerfTaskUpdateResponse self = new AgoalPerfTaskUpdateResponse();
        return TeaModel.build(map, self);
    }

    public AgoalPerfTaskUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalPerfTaskUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalPerfTaskUpdateResponse setBody(AgoalPerfTaskUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalPerfTaskUpdateResponseBody getBody() {
        return this.body;
    }

}
