// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmMokaOapiResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrmMokaOapiResponseBody body;

    public static HrmMokaOapiResponse build(java.util.Map<String, ?> map) throws Exception {
        HrmMokaOapiResponse self = new HrmMokaOapiResponse();
        return TeaModel.build(map, self);
    }

    public HrmMokaOapiResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrmMokaOapiResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrmMokaOapiResponse setBody(HrmMokaOapiResponseBody body) {
        this.body = body;
        return this;
    }
    public HrmMokaOapiResponseBody getBody() {
        return this.body;
    }

}
