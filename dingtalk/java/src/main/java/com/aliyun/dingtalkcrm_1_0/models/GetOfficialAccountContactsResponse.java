// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetOfficialAccountContactsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetOfficialAccountContactsResponse setBody(GetOfficialAccountContactsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOfficialAccountContactsResponseBody getBody() {
        return this.body;
    }

}
