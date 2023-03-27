// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetStaffInfoByWorkNoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetStaffInfoByWorkNoResponseBody body;

    public static GetStaffInfoByWorkNoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetStaffInfoByWorkNoResponse self = new GetStaffInfoByWorkNoResponse();
        return TeaModel.build(map, self);
    }

    public GetStaffInfoByWorkNoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetStaffInfoByWorkNoResponse setBody(GetStaffInfoByWorkNoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetStaffInfoByWorkNoResponseBody getBody() {
        return this.body;
    }

}
