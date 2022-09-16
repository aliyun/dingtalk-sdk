// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetConditionFormComponentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetConditionFormComponentResponseBody body;

    public static GetConditionFormComponentResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConditionFormComponentResponse self = new GetConditionFormComponentResponse();
        return TeaModel.build(map, self);
    }

    public GetConditionFormComponentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConditionFormComponentResponse setBody(GetConditionFormComponentResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConditionFormComponentResponseBody getBody() {
        return this.body;
    }

}
