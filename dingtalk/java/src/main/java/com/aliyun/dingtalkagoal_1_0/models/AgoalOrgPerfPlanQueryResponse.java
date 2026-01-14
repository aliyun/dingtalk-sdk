// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgPerfPlanQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalOrgPerfPlanQueryResponseBody body;

    public static AgoalOrgPerfPlanQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgPerfPlanQueryResponse self = new AgoalOrgPerfPlanQueryResponse();
        return TeaModel.build(map, self);
    }

    public AgoalOrgPerfPlanQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalOrgPerfPlanQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalOrgPerfPlanQueryResponse setBody(AgoalOrgPerfPlanQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalOrgPerfPlanQueryResponseBody getBody() {
        return this.body;
    }

}
