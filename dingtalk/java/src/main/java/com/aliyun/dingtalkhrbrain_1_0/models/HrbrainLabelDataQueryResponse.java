// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelDataQueryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelDataQueryResponseBody body;

    public static HrbrainLabelDataQueryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelDataQueryResponse self = new HrbrainLabelDataQueryResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelDataQueryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelDataQueryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelDataQueryResponse setBody(HrbrainLabelDataQueryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelDataQueryResponseBody getBody() {
        return this.body;
    }

}
