// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainImportLabelProfSkillResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public HrbrainImportLabelProfSkillResponseBody body;

    public static HrbrainImportLabelProfSkillResponse build(java.util.Map<String, ?> map) throws Exception {
        HrbrainImportLabelProfSkillResponse self = new HrbrainImportLabelProfSkillResponse();
        return TeaModel.build(map, self);
    }

    public HrbrainImportLabelProfSkillResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public HrbrainImportLabelProfSkillResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public HrbrainImportLabelProfSkillResponse setBody(HrbrainImportLabelProfSkillResponseBody body) {
        this.body = body;
        return this;
    }
    public HrbrainImportLabelProfSkillResponseBody getBody() {
        return this.body;
    }

}
