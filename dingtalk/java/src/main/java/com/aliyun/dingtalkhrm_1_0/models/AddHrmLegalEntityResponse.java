// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddHrmLegalEntityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddHrmLegalEntityResponseBody body;

    public static AddHrmLegalEntityResponse build(java.util.Map<String, ?> map) throws Exception {
        AddHrmLegalEntityResponse self = new AddHrmLegalEntityResponse();
        return TeaModel.build(map, self);
    }

    public AddHrmLegalEntityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddHrmLegalEntityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddHrmLegalEntityResponse setBody(AddHrmLegalEntityResponseBody body) {
        this.body = body;
        return this;
    }
    public AddHrmLegalEntityResponseBody getBody() {
        return this.body;
    }

}
