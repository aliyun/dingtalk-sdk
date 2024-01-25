// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesTeamMgmtResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IndustryManufactureMesTeamMgmtResponseBody body;

    public static IndustryManufactureMesTeamMgmtResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesTeamMgmtResponse self = new IndustryManufactureMesTeamMgmtResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesTeamMgmtResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureMesTeamMgmtResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IndustryManufactureMesTeamMgmtResponse setBody(IndustryManufactureMesTeamMgmtResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesTeamMgmtResponseBody getBody() {
        return this.body;
    }

}
