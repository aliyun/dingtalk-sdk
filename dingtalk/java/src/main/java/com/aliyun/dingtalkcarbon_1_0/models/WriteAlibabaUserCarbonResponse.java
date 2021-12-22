// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0.models;

import com.aliyun.tea.*;

public class WriteAlibabaUserCarbonResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public WriteAlibabaUserCarbonResponseBody body;

    public static WriteAlibabaUserCarbonResponse build(java.util.Map<String, ?> map) throws Exception {
        WriteAlibabaUserCarbonResponse self = new WriteAlibabaUserCarbonResponse();
        return TeaModel.build(map, self);
    }

    public WriteAlibabaUserCarbonResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public WriteAlibabaUserCarbonResponse setBody(WriteAlibabaUserCarbonResponseBody body) {
        this.body = body;
        return this;
    }
    public WriteAlibabaUserCarbonResponseBody getBody() {
        return this.body;
    }

}
