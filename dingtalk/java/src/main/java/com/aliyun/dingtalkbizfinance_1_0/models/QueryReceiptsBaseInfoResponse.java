// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryReceiptsBaseInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryReceiptsBaseInfoResponseBody body;

    public static QueryReceiptsBaseInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryReceiptsBaseInfoResponse self = new QueryReceiptsBaseInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryReceiptsBaseInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryReceiptsBaseInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryReceiptsBaseInfoResponse setBody(QueryReceiptsBaseInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryReceiptsBaseInfoResponseBody getBody() {
        return this.body;
    }

}
