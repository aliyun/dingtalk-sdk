// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryDismissionStaffIdListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryDismissionStaffIdListResponse setBody(QueryDismissionStaffIdListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDismissionStaffIdListResponseBody getBody() {
        return this.body;
    }

}
