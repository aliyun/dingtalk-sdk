// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetChangeRecordResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetChangeRecordResponseBody body;

    public static GetChangeRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        GetChangeRecordResponse self = new GetChangeRecordResponse();
        return TeaModel.build(map, self);
    }

    public GetChangeRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetChangeRecordResponse setBody(GetChangeRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public GetChangeRecordResponseBody getBody() {
        return this.body;
    }

}
