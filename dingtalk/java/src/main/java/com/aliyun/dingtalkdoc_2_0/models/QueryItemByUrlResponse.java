// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryItemByUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryItemByUrlResponseBody body;

    public static QueryItemByUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryItemByUrlResponse self = new QueryItemByUrlResponse();
        return TeaModel.build(map, self);
    }

    public QueryItemByUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryItemByUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryItemByUrlResponse setBody(QueryItemByUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryItemByUrlResponseBody getBody() {
        return this.body;
    }

}
