// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomRosterFieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateCustomRosterFieldResponseBody body;

    public static UpdateCustomRosterFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomRosterFieldResponse self = new UpdateCustomRosterFieldResponse();
        return TeaModel.build(map, self);
    }

    public UpdateCustomRosterFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateCustomRosterFieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateCustomRosterFieldResponse setBody(UpdateCustomRosterFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateCustomRosterFieldResponseBody getBody() {
        return this.body;
    }

}
