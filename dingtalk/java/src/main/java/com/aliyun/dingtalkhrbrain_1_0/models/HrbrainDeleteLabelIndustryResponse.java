// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainDeleteLabelIndustryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainDeleteLabelIndustryResponseBody body;

    public static HrbrainDeleteLabelIndustryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainDeleteLabelIndustryResponse self = new HrbrainDeleteLabelIndustryResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainDeleteLabelIndustryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainDeleteLabelIndustryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainDeleteLabelIndustryResponse setBody(HrbrainDeleteLabelIndustryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainDeleteLabelIndustryResponseBody getBody() {
        return this.body;
    }

}
