// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetAdjustmentsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAdjustmentsResponseBody body;

    public static GetAdjustmentsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAdjustmentsResponse self = new GetAdjustmentsResponse();
        return TeaModel.build(map, self);
    }

    public GetAdjustmentsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAdjustmentsResponse setBody(GetAdjustmentsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAdjustmentsResponseBody getBody() {
        return this.body;
    }

}
