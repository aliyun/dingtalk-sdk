// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetSignRecordByUserIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSignRecordByUserIdResponseBody body;

    public static GetSignRecordByUserIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignRecordByUserIdResponse self = new GetSignRecordByUserIdResponse();
        return TeaModel.build(map, self);
    }

    public GetSignRecordByUserIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignRecordByUserIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSignRecordByUserIdResponse setBody(GetSignRecordByUserIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignRecordByUserIdResponseBody getBody() {
        return this.body;
    }

}
