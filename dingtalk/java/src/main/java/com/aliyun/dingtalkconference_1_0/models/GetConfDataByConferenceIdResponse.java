// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetConfDataByConferenceIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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
