// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryTransferCourseResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryTransferCourseResponseBody body;

    public static QueryTransferCourseResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryTransferCourseResponse self = new QueryTransferCourseResponse();
        return TeaModel.build(map, self);
    }

    public QueryTransferCourseResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryTransferCourseResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryTransferCourseResponse setBody(QueryTransferCourseResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryTransferCourseResponseBody getBody() {
        return this.body;
    }

}
