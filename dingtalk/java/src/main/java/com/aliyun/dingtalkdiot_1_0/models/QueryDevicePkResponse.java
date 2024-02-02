// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class QueryDevicePkResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDevicePkResponseBody body;

    public static QueryDevicePkResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDevicePkResponse self = new QueryDevicePkResponse();
        return TeaModel.build(map, self);
    }

    public QueryDevicePkResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDevicePkResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDevicePkResponse setBody(QueryDevicePkResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDevicePkResponseBody getBody() {
        return this.body;
    }

}
