// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgObjectiveListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalOrgObjectiveListResponseBody body;

    public static AgoalOrgObjectiveListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgObjectiveListResponse self = new AgoalOrgObjectiveListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalOrgObjectiveListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalOrgObjectiveListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalOrgObjectiveListResponse setBody(AgoalOrgObjectiveListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalOrgObjectiveListResponseBody getBody() {
        return this.body;
    }

}
