// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class WeiqiaoAluminumQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public WeiqiaoAluminumQueryResponseBody body;

    public static WeiqiaoAluminumQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        WeiqiaoAluminumQueryResponse self = new WeiqiaoAluminumQueryResponse();
        return TeaModel.build(map, self);
    }

    public WeiqiaoAluminumQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WeiqiaoAluminumQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WeiqiaoAluminumQueryResponse setBody(WeiqiaoAluminumQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public WeiqiaoAluminumQueryResponseBody getBody() {
        return this.body;
    }

}
