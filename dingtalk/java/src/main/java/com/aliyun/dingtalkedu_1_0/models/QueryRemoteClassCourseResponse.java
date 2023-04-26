// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryRemoteClassCourseResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryRemoteClassCourseResponseBody body;

    public static QueryRemoteClassCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryRemoteClassCourseResponse self = new QueryRemoteClassCourseResponse();
        return TeaModel.build(map, self);
    }

    public QueryRemoteClassCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryRemoteClassCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryRemoteClassCourseResponse setBody(QueryRemoteClassCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryRemoteClassCourseResponseBody getBody() {
        return this.body;
    }

}
