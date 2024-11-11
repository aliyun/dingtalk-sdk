// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryTeacherCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTeacherCourseResponseBody body;

    public static QueryTeacherCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTeacherCourseResponse self = new QueryTeacherCourseResponse();
        return TeaModel.build(map, self);
    }

    public QueryTeacherCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTeacherCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTeacherCourseResponse setBody(QueryTeacherCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTeacherCourseResponseBody getBody() {
        return this.body;
    }

}
