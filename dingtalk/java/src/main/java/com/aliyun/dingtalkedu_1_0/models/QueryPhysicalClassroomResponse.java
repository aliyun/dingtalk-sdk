// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryPhysicalClassroomResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPhysicalClassroomResponseBody body;

    public static QueryPhysicalClassroomResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPhysicalClassroomResponse self = new QueryPhysicalClassroomResponse();
        return TeaModel.build(map, self);
    }

    public QueryPhysicalClassroomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPhysicalClassroomResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPhysicalClassroomResponse setBody(QueryPhysicalClassroomResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPhysicalClassroomResponseBody getBody() {
        return this.body;
    }

}
