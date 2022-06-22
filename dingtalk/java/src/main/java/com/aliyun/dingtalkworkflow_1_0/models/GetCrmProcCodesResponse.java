// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetCrmProcCodesResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCrmProcCodesResponseBody body;

    public static GetCrmProcCodesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCrmProcCodesResponse self = new GetCrmProcCodesResponse();
        return TeaModel.build(map, self);
    }

    public GetCrmProcCodesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCrmProcCodesResponse setBody(GetCrmProcCodesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCrmProcCodesResponseBody getBody() {
        return this.body;
    }

}
