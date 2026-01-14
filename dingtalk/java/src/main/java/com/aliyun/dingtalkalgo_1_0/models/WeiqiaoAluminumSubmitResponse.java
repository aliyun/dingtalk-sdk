// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class WeiqiaoAluminumSubmitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public WeiqiaoAluminumSubmitResponseBody body;

    public static WeiqiaoAluminumSubmitResponse build(java.util.Map<String, ?> map) throws Exception {
        WeiqiaoAluminumSubmitResponse self = new WeiqiaoAluminumSubmitResponse();
        return TeaModel.build(map, self);
    }

    public WeiqiaoAluminumSubmitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WeiqiaoAluminumSubmitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public WeiqiaoAluminumSubmitResponse setBody(WeiqiaoAluminumSubmitResponseBody body) {
        this.body = body;
        return this;
    }
    public WeiqiaoAluminumSubmitResponseBody getBody() {
        return this.body;
    }

}
