// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryOrderConvertResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOrderConvertResultResponseBody body;

    public static QueryOrderConvertResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOrderConvertResultResponse self = new QueryOrderConvertResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryOrderConvertResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOrderConvertResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOrderConvertResultResponse setBody(QueryOrderConvertResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOrderConvertResultResponseBody getBody() {
        return this.body;
    }

}
