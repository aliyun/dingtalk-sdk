// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class GetSignNoticeUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public GetSignNoticeUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSignNoticeUrlResponse setBody(GetSignNoticeUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSignNoticeUrlResponseBody getBody() {
        return this.body;
    }

}
