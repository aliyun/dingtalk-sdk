// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetEmploymentRecordByWorkNoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetEmploymentRecordByWorkNoResponseBody body;

    public static GetEmploymentRecordByWorkNoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetEmploymentRecordByWorkNoResponse self = new GetEmploymentRecordByWorkNoResponse();
        return TeaModel.build(map, self);
    }

    public GetEmploymentRecordByWorkNoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetEmploymentRecordByWorkNoResponse setBody(GetEmploymentRecordByWorkNoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetEmploymentRecordByWorkNoResponseBody getBody() {
        return this.body;
    }

}
