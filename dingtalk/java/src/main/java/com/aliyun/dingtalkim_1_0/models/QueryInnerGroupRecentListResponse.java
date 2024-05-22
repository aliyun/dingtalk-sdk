// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryInnerGroupRecentListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryInnerGroupRecentListResponseBody body;

    public static QueryInnerGroupRecentListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryInnerGroupRecentListResponse self = new QueryInnerGroupRecentListResponse();
        return TeaModel.build(map, self);
    }

    public QueryInnerGroupRecentListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryInnerGroupRecentListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryInnerGroupRecentListResponse setBody(QueryInnerGroupRecentListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryInnerGroupRecentListResponseBody getBody() {
        return this.body;
    }

}
