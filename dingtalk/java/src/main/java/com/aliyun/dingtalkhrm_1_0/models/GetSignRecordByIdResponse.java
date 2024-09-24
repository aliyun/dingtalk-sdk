// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetSignRecordByIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSignRecordByIdResponseBody body;

    public static GetSignRecordByIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignRecordByIdResponse self = new GetSignRecordByIdResponse();
        return TeaModel.build(map, self);
    }

    public GetSignRecordByIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignRecordByIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSignRecordByIdResponse setBody(GetSignRecordByIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignRecordByIdResponseBody getBody() {
        return this.body;
    }

}
