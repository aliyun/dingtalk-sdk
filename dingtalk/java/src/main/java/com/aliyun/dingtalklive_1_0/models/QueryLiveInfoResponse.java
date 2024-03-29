// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QueryLiveInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryLiveInfoResponseBody body;

    public static QueryLiveInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryLiveInfoResponse self = new QueryLiveInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryLiveInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryLiveInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryLiveInfoResponse setBody(QueryLiveInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryLiveInfoResponseBody getBody() {
        return this.body;
    }

}
