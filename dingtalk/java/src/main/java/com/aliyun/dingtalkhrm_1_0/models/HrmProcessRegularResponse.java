// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessRegularResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmProcessRegularResponseBody body;

    public static HrmProcessRegularResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessRegularResponse self = new HrmProcessRegularResponse();
        return TeaModel.build(map, self);
    }

    public HrmProcessRegularResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmProcessRegularResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmProcessRegularResponse setBody(HrmProcessRegularResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmProcessRegularResponseBody getBody() {
        return this.body;
    }

}
