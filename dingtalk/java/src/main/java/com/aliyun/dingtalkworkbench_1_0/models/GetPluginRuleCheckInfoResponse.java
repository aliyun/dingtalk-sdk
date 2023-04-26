// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class GetPluginRuleCheckInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetPluginRuleCheckInfoResponseBody body;

    public static GetPluginRuleCheckInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPluginRuleCheckInfoResponse self = new GetPluginRuleCheckInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetPluginRuleCheckInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPluginRuleCheckInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPluginRuleCheckInfoResponse setBody(GetPluginRuleCheckInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPluginRuleCheckInfoResponseBody getBody() {
        return this.body;
    }

}
