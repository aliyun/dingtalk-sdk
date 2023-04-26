// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupSetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryGroupSetResponseBody body;

    public static QueryGroupSetResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupSetResponse self = new QueryGroupSetResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupSetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupSetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupSetResponse setBody(QueryGroupSetResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupSetResponseBody getBody() {
        return this.body;
    }

}
