// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SortConvNavTabResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SortConvNavTabResponseBody body;

    public static SortConvNavTabResponse build(java.util.Map<String, ?> map) throws Exception {
        SortConvNavTabResponse self = new SortConvNavTabResponse();
        return TeaModel.build(map, self);
    }

    public SortConvNavTabResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SortConvNavTabResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SortConvNavTabResponse setBody(SortConvNavTabResponseBody body) {
        this.body = body;
        return this;
    }
    public SortConvNavTabResponseBody getBody() {
        return this.body;
    }

}
