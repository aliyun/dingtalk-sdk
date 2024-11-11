// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryClassCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryClassCourseResponseBody body;

    public static QueryClassCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryClassCourseResponse self = new QueryClassCourseResponse();
        return TeaModel.build(map, self);
    }

    public QueryClassCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryClassCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryClassCourseResponse setBody(QueryClassCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryClassCourseResponseBody getBody() {
        return this.body;
    }

}
