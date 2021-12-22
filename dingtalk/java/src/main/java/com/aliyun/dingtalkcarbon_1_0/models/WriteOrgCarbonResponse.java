// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteOrgCarbonResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public WriteOrgCarbonResponseBody body;

    public static WriteOrgCarbonResponse build(java.util.Map<String, ?> map) throws Exception {
        WriteOrgCarbonResponse self = new WriteOrgCarbonResponse();
        return TeaModel.build(map, self);
    }

    public WriteOrgCarbonResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WriteOrgCarbonResponse setBody(WriteOrgCarbonResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteOrgCarbonResponseBody getBody() {
        return this.body;
    }

}
