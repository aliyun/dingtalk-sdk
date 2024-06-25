// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryOpenGroupBaseInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOpenGroupBaseInfoResponseBody body;

    public static QueryOpenGroupBaseInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOpenGroupBaseInfoResponse self = new QueryOpenGroupBaseInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryOpenGroupBaseInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOpenGroupBaseInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOpenGroupBaseInfoResponse setBody(QueryOpenGroupBaseInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOpenGroupBaseInfoResponseBody getBody() {
        return this.body;
    }

}
