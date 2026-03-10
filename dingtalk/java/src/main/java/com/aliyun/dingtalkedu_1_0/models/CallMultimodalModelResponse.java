// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CallMultimodalModelResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CallMultimodalModelResponseBody body;

    public static CallMultimodalModelResponse build(java.util.Map<String, ?> map) throws Exception {
        CallMultimodalModelResponse self = new CallMultimodalModelResponse();
        return TeaModel.build(map, self);
    }

    public CallMultimodalModelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CallMultimodalModelResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CallMultimodalModelResponse setBody(CallMultimodalModelResponseBody body) {
        this.body = body;
        return this;
    }
    public CallMultimodalModelResponseBody getBody() {
        return this.body;
    }

}
