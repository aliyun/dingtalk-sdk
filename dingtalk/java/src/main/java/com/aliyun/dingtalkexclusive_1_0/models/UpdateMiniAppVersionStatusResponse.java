// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateMiniAppVersionStatusResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateMiniAppVersionStatusResponseBody body;

    public static UpdateMiniAppVersionStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMiniAppVersionStatusResponse self = new UpdateMiniAppVersionStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMiniAppVersionStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateMiniAppVersionStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateMiniAppVersionStatusResponse setBody(UpdateMiniAppVersionStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateMiniAppVersionStatusResponseBody getBody() {
        return this.body;
    }

}
