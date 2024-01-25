// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class UpgradeTemplateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpgradeTemplateResponseBody body;

    public static UpgradeTemplateResponse build(java.util.Map<String, ?> map) throws Exception {
        UpgradeTemplateResponse self = new UpgradeTemplateResponse();
        return TeaModel.build(map, self);
    }

    public UpgradeTemplateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpgradeTemplateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpgradeTemplateResponse setBody(UpgradeTemplateResponseBody body) {
        this.body = body;
        return this;
    }
    public UpgradeTemplateResponseBody getBody() {
        return this.body;
    }

}
