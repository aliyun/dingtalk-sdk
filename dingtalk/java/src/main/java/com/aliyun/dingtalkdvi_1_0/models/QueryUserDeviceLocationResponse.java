// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryUserDeviceLocationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserDeviceLocationResponseBody body;

    public static QueryUserDeviceLocationResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserDeviceLocationResponse self = new QueryUserDeviceLocationResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserDeviceLocationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserDeviceLocationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserDeviceLocationResponse setBody(QueryUserDeviceLocationResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserDeviceLocationResponseBody getBody() {
        return this.body;
    }

}
