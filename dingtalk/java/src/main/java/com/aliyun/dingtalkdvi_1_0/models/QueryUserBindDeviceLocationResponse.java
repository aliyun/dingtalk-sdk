// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryUserBindDeviceLocationResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryUserBindDeviceLocationResponseBody body;

    public static QueryUserBindDeviceLocationResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryUserBindDeviceLocationResponse self = new QueryUserBindDeviceLocationResponse();
        return TeaModel.build(map, self);
    }

    public QueryUserBindDeviceLocationResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryUserBindDeviceLocationResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryUserBindDeviceLocationResponse setBody(QueryUserBindDeviceLocationResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryUserBindDeviceLocationResponseBody getBody() {
        return this.body;
    }

}
