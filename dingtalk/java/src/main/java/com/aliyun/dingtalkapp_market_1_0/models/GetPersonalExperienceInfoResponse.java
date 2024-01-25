// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class GetPersonalExperienceInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPersonalExperienceInfoResponseBody body;

    public static GetPersonalExperienceInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPersonalExperienceInfoResponse self = new GetPersonalExperienceInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetPersonalExperienceInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPersonalExperienceInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPersonalExperienceInfoResponse setBody(GetPersonalExperienceInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPersonalExperienceInfoResponseBody getBody() {
        return this.body;
    }

}
