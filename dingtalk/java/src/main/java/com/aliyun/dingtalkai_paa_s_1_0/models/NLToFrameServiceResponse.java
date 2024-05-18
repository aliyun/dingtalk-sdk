// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0.models;

import com.aliyun.tea.*;

public class NLToFrameServiceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public NLToFrameServiceResponseBody body;

    public static NLToFrameServiceResponse build(java.util.Map<String, ?> map) throws Exception {
        NLToFrameServiceResponse self = new NLToFrameServiceResponse();
        return TeaModel.build(map, self);
    }

    public NLToFrameServiceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public NLToFrameServiceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public NLToFrameServiceResponse setBody(NLToFrameServiceResponseBody body) {
        this.body = body;
        return this;
    }
    public NLToFrameServiceResponseBody getBody() {
        return this.body;
    }

}
