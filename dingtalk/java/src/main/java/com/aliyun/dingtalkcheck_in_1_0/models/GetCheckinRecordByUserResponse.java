// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcheck_in_1_0.models;

import com.aliyun.tea.*;

public class GetCheckinRecordByUserResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetCheckinRecordByUserResponseBody body;

    public static GetCheckinRecordByUserResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCheckinRecordByUserResponse self = new GetCheckinRecordByUserResponse();
        return TeaModel.build(map, self);
    }

    public GetCheckinRecordByUserResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCheckinRecordByUserResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCheckinRecordByUserResponse setBody(GetCheckinRecordByUserResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCheckinRecordByUserResponseBody getBody() {
        return this.body;
    }

}
