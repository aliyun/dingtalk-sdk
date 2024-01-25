// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOfficialAccountContactInfoResponseBody body;

    public static GetOfficialAccountContactInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactInfoResponse self = new GetOfficialAccountContactInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOfficialAccountContactInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOfficialAccountContactInfoResponse setBody(GetOfficialAccountContactInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOfficialAccountContactInfoResponseBody getBody() {
        return this.body;
    }

}
