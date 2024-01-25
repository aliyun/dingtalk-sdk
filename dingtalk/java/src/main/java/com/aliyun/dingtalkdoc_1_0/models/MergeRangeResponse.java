// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class MergeRangeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MergeRangeResponseBody body;

    public static MergeRangeResponse build(java.util.Map<String, ?> map) throws Exception {
        MergeRangeResponse self = new MergeRangeResponse();
        return TeaModel.build(map, self);
    }

    public MergeRangeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MergeRangeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MergeRangeResponse setBody(MergeRangeResponseBody body) {
        this.body = body;
        return this;
    }
    public MergeRangeResponseBody getBody() {
        return this.body;
    }

}
