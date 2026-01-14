// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainLabelCategoryUpdateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainLabelCategoryUpdateResponseBody body;

    public static HrbrainLabelCategoryUpdateResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainLabelCategoryUpdateResponse self = new HrbrainLabelCategoryUpdateResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainLabelCategoryUpdateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainLabelCategoryUpdateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainLabelCategoryUpdateResponse setBody(HrbrainLabelCategoryUpdateResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainLabelCategoryUpdateResponseBody getBody() {
        return this.body;
    }

}
