// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetOssTempUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetOssTempUrlResponseBody body;

    public static GetOssTempUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOssTempUrlResponse self = new GetOssTempUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetOssTempUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOssTempUrlResponse setBody(GetOssTempUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOssTempUrlResponseBody getBody() {
        return this.body;
    }

}
