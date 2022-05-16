// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesTeamMgmtResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public IndustryManufactureMesTeamMgmtResponse setBody(IndustryManufactureMesTeamMgmtResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureMesTeamMgmtResponseBody getBody() {
        return this.body;
    }

}
