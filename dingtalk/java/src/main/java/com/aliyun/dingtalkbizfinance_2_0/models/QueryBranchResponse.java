// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class QueryBranchResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBranchResponseBody body;

    public static QueryBranchResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBranchResponse self = new QueryBranchResponse();
        return TeaModel.build(map, self);
    }

    public QueryBranchResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBranchResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBranchResponse setBody(QueryBranchResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBranchResponseBody getBody() {
        return this.body;
    }

}
