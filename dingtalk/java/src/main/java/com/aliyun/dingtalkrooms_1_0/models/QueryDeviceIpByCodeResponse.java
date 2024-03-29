// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceIpByCodeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDeviceIpByCodeResponseBody body;

    public static QueryDeviceIpByCodeResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceIpByCodeResponse self = new QueryDeviceIpByCodeResponse();
        return TeaModel.build(map, self);
    }

    public QueryDeviceIpByCodeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDeviceIpByCodeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDeviceIpByCodeResponse setBody(QueryDeviceIpByCodeResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDeviceIpByCodeResponseBody getBody() {
        return this.body;
    }

}
