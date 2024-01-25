// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryBizOptLogResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryBizOptLogResponseBody body;

    public static QueryBizOptLogResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryBizOptLogResponse self = new QueryBizOptLogResponse();
        return TeaModel.build(map, self);
    }

    public QueryBizOptLogResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryBizOptLogResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryBizOptLogResponse setBody(QueryBizOptLogResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryBizOptLogResponseBody getBody() {
        return this.body;
    }

}
