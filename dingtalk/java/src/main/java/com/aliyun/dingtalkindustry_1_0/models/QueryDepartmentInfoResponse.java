// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDepartmentInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDepartmentInfoResponseBody body;

    public static QueryDepartmentInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDepartmentInfoResponse self = new QueryDepartmentInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryDepartmentInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDepartmentInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDepartmentInfoResponse setBody(QueryDepartmentInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDepartmentInfoResponseBody getBody() {
        return this.body;
    }

}
