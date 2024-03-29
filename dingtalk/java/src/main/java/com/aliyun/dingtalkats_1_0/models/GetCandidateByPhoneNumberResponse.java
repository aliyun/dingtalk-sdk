// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class GetCandidateByPhoneNumberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetCandidateByPhoneNumberResponseBody body;

    public static GetCandidateByPhoneNumberResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCandidateByPhoneNumberResponse self = new GetCandidateByPhoneNumberResponse();
        return TeaModel.build(map, self);
    }

    public GetCandidateByPhoneNumberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCandidateByPhoneNumberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetCandidateByPhoneNumberResponse setBody(GetCandidateByPhoneNumberResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCandidateByPhoneNumberResponseBody getBody() {
        return this.body;
    }

}
