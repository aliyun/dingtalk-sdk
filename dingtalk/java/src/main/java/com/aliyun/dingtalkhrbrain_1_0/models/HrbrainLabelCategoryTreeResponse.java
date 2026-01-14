// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelCategoryTreeResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelCategoryTreeResponseBody body;

    public static HrbrainLabelCategoryTreeResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelCategoryTreeResponse self = new HrbrainLabelCategoryTreeResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelCategoryTreeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelCategoryTreeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelCategoryTreeResponse setBody(HrbrainLabelCategoryTreeResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelCategoryTreeResponseBody getBody() {
        return this.body;
    }

}
