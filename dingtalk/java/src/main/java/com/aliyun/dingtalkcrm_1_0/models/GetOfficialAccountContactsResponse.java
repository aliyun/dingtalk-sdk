// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOfficialAccountContactsResponseBody body;

    public static GetOfficialAccountContactsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOfficialAccountContactsResponse self = new GetOfficialAccountContactsResponse();
        return TeaModel.build(map, self);
    }

    public GetOfficialAccountContactsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOfficialAccountContactsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOfficialAccountContactsResponse setBody(GetOfficialAccountContactsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOfficialAccountContactsResponseBody getBody() {
        return this.body;
    }

}
