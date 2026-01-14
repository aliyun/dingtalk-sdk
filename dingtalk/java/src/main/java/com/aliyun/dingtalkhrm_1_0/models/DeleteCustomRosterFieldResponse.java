// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCustomRosterFieldResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteCustomRosterFieldResponseBody body;

    public static DeleteCustomRosterFieldResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteCustomRosterFieldResponse self = new DeleteCustomRosterFieldResponse();
        return TeaModel.build(map, self);
    }

    public DeleteCustomRosterFieldResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteCustomRosterFieldResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteCustomRosterFieldResponse setBody(DeleteCustomRosterFieldResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteCustomRosterFieldResponseBody getBody() {
        return this.body;
    }

}
