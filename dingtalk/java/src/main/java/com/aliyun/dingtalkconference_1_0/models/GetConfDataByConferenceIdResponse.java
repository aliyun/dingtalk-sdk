// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetConfDataByConferenceIdResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetConfDataByConferenceIdResponseBody body;

    public static GetConfDataByConferenceIdResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConfDataByConferenceIdResponse self = new GetConfDataByConferenceIdResponse();
        return TeaModel.build(map, self);
    }

    public GetConfDataByConferenceIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConfDataByConferenceIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetConfDataByConferenceIdResponse setBody(GetConfDataByConferenceIdResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConfDataByConferenceIdResponseBody getBody() {
        return this.body;
    }

}
