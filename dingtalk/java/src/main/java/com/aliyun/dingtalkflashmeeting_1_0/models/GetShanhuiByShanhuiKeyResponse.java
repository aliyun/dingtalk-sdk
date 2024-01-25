// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetShanhuiByShanhuiKeyResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetShanhuiByShanhuiKeyResponseBody body;

    public static GetShanhuiByShanhuiKeyResponse build(java.util.Map<String, ?> map) throws Exception {
        GetShanhuiByShanhuiKeyResponse self = new GetShanhuiByShanhuiKeyResponse();
        return TeaModel.build(map, self);
    }

    public GetShanhuiByShanhuiKeyResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetShanhuiByShanhuiKeyResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetShanhuiByShanhuiKeyResponse setBody(GetShanhuiByShanhuiKeyResponseBody body) {
        this.body = body;
        return this;
    }
    public GetShanhuiByShanhuiKeyResponseBody getBody() {
        return this.body;
    }

}
