// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgObjectiveQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalOrgObjectiveQueryResponseBody body;

    public static AgoalOrgObjectiveQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgObjectiveQueryResponse self = new AgoalOrgObjectiveQueryResponse();
        return TeaModel.build(map, self);
    }

    public AgoalOrgObjectiveQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalOrgObjectiveQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalOrgObjectiveQueryResponse setBody(AgoalOrgObjectiveQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalOrgObjectiveQueryResponseBody getBody() {
        return this.body;
    }

}
