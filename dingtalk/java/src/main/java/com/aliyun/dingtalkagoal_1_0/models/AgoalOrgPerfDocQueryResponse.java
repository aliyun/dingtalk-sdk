// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgPerfDocQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalOrgPerfDocQueryResponseBody body;

    public static AgoalOrgPerfDocQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgPerfDocQueryResponse self = new AgoalOrgPerfDocQueryResponse();
        return TeaModel.build(map, self);
    }

    public AgoalOrgPerfDocQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalOrgPerfDocQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalOrgPerfDocQueryResponse setBody(AgoalOrgPerfDocQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalOrgPerfDocQueryResponseBody getBody() {
        return this.body;
    }

}
