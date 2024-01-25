// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_phone_1_0.models;

import com.aliyun.tea.*;

public class QueryCallConfigResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryCallConfigResponseBody body;

    public static QueryCallConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCallConfigResponse self = new QueryCallConfigResponse();
        return TeaModel.build(map, self);
    }

    public QueryCallConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCallConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryCallConfigResponse setBody(QueryCallConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCallConfigResponseBody getBody() {
        return this.body;
    }

}
