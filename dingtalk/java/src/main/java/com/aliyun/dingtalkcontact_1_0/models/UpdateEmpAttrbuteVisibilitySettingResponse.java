// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UpdateEmpAttrbuteVisibilitySettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateEmpAttrbuteVisibilitySettingResponseBody body;

    public static UpdateEmpAttrbuteVisibilitySettingResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateEmpAttrbuteVisibilitySettingResponse self = new UpdateEmpAttrbuteVisibilitySettingResponse();
        return TeaModel.build(map, self);
    }

    public UpdateEmpAttrbuteVisibilitySettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateEmpAttrbuteVisibilitySettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateEmpAttrbuteVisibilitySettingResponse setBody(UpdateEmpAttrbuteVisibilitySettingResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateEmpAttrbuteVisibilitySettingResponseBody getBody() {
        return this.body;
    }

}
