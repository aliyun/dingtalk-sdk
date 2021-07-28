// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetConferenceDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetConferenceDetailResponseBody body;

    public static GetConferenceDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        GetConferenceDetailResponse self = new GetConferenceDetailResponse();
        return TeaModel.build(map, self);
    }

    public GetConferenceDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetConferenceDetailResponse setBody(GetConferenceDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public GetConferenceDetailResponseBody getBody() {
        return this.body;
    }

}
