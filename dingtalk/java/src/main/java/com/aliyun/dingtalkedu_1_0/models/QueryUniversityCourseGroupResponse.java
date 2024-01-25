// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryUniversityCourseGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUniversityCourseGroupResponseBody body;

    public static QueryUniversityCourseGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUniversityCourseGroupResponse self = new QueryUniversityCourseGroupResponse();
        return TeaModel.build(map, self);
    }

    public QueryUniversityCourseGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUniversityCourseGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUniversityCourseGroupResponse setBody(QueryUniversityCourseGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUniversityCourseGroupResponseBody getBody() {
        return this.body;
    }

}
