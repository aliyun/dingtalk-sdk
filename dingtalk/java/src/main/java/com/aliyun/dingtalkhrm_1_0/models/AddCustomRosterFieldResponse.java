// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class AddCustomRosterFieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AddCustomRosterFieldResponseBody body;

    public static AddCustomRosterFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        AddCustomRosterFieldResponse self = new AddCustomRosterFieldResponse();
        return TeaModel.build(map, self);
    }

    public AddCustomRosterFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddCustomRosterFieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddCustomRosterFieldResponse setBody(AddCustomRosterFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public AddCustomRosterFieldResponseBody getBody() {
        return this.body;
    }

}
