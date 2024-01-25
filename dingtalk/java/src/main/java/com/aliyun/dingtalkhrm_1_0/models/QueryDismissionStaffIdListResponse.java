// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryDismissionStaffIdListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDismissionStaffIdListResponseBody body;

    public static QueryDismissionStaffIdListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDismissionStaffIdListResponse self = new QueryDismissionStaffIdListResponse();
        return TeaModel.build(map, self);
    }

    public QueryDismissionStaffIdListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDismissionStaffIdListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDismissionStaffIdListResponse setBody(QueryDismissionStaffIdListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDismissionStaffIdListResponseBody getBody() {
        return this.body;
    }

}
