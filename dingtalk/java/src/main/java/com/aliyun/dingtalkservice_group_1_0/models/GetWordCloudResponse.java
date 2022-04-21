// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetWordCloudResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetWordCloudResponseBody body;

    public static GetWordCloudResponse build(java.util.Map<String, ?> map) throws Exception {
        GetWordCloudResponse self = new GetWordCloudResponse();
        return TeaModel.build(map, self);
    }

    public GetWordCloudResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetWordCloudResponse setBody(GetWordCloudResponseBody body) {
        this.body = body;
        return this;
    }
    public GetWordCloudResponseBody getBody() {
        return this.body;
    }

}
