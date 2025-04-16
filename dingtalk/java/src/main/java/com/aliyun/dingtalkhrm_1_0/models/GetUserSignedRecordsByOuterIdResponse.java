// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetUserSignedRecordsByOuterIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUserSignedRecordsByOuterIdResponseBody body;

    public static GetUserSignedRecordsByOuterIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUserSignedRecordsByOuterIdResponse self = new GetUserSignedRecordsByOuterIdResponse();
        return TeaModel.build(map, self);
    }

    public GetUserSignedRecordsByOuterIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUserSignedRecordsByOuterIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUserSignedRecordsByOuterIdResponse setBody(GetUserSignedRecordsByOuterIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUserSignedRecordsByOuterIdResponseBody getBody() {
        return this.body;
    }

}
