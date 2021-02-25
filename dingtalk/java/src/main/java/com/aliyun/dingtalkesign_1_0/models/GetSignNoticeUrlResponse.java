// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetSignNoticeUrlResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetSignNoticeUrlResponseBody body;

    public static GetSignNoticeUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSignNoticeUrlResponse self = new GetSignNoticeUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetSignNoticeUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSignNoticeUrlResponse setBody(GetSignNoticeUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignNoticeUrlResponseBody getBody() {
        return this.body;
    }

}
