// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryCollegeContactUserDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCollegeContactUserDetailResponseBody body;

    public static QueryCollegeContactUserDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCollegeContactUserDetailResponse self = new QueryCollegeContactUserDetailResponse();
        return TeaModel.build(map, self);
    }

    public QueryCollegeContactUserDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCollegeContactUserDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCollegeContactUserDetailResponse setBody(QueryCollegeContactUserDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCollegeContactUserDetailResponseBody getBody() {
        return this.body;
    }

}
