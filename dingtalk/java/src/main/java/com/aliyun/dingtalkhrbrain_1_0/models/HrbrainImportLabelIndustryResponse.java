// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelIndustryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportLabelIndustryResponseBody body;

    public static HrbrainImportLabelIndustryResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelIndustryResponse self = new HrbrainImportLabelIndustryResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelIndustryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportLabelIndustryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportLabelIndustryResponse setBody(HrbrainImportLabelIndustryResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportLabelIndustryResponseBody getBody() {
        return this.body;
    }

}
