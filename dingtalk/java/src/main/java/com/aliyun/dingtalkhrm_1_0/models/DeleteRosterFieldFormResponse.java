// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteRosterFieldFormResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteRosterFieldFormResponseBody body;

    public static DeleteRosterFieldFormResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRosterFieldFormResponse self = new DeleteRosterFieldFormResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRosterFieldFormResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteRosterFieldFormResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteRosterFieldFormResponse setBody(DeleteRosterFieldFormResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRosterFieldFormResponseBody getBody() {
        return this.body;
    }

}
