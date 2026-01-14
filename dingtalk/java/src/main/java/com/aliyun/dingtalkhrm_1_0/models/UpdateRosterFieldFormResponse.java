// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateRosterFieldFormResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateRosterFieldFormResponseBody body;

    public static UpdateRosterFieldFormResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRosterFieldFormResponse self = new UpdateRosterFieldFormResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRosterFieldFormResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRosterFieldFormResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateRosterFieldFormResponse setBody(UpdateRosterFieldFormResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRosterFieldFormResponseBody getBody() {
        return this.body;
    }

}
