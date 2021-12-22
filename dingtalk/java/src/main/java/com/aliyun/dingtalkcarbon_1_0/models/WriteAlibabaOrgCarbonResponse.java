// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteAlibabaOrgCarbonResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public WriteAlibabaOrgCarbonResponseBody body;

    public static WriteAlibabaOrgCarbonResponse build(java.util.Map<String, ?> map) throws Exception {
        WriteAlibabaOrgCarbonResponse self = new WriteAlibabaOrgCarbonResponse();
        return TeaModel.build(map, self);
    }

    public WriteAlibabaOrgCarbonResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WriteAlibabaOrgCarbonResponse setBody(WriteAlibabaOrgCarbonResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteAlibabaOrgCarbonResponseBody getBody() {
        return this.body;
    }

}
