// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupInfoByAppCidsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGroupInfoByAppCidsResponseBody body;

    public static QueryGroupInfoByAppCidsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupInfoByAppCidsResponse self = new QueryGroupInfoByAppCidsResponse();
        return TeaModel.build(map, self);
    }

    public QueryGroupInfoByAppCidsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGroupInfoByAppCidsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGroupInfoByAppCidsResponse setBody(QueryGroupInfoByAppCidsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGroupInfoByAppCidsResponseBody getBody() {
        return this.body;
    }

}
