// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelDataDeleteResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelDataDeleteResponseBody body;

    public static HrbrainLabelDataDeleteResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelDataDeleteResponse self = new HrbrainLabelDataDeleteResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelDataDeleteResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelDataDeleteResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelDataDeleteResponse setBody(HrbrainLabelDataDeleteResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelDataDeleteResponseBody getBody() {
        return this.body;
    }

}
