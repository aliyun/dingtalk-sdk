// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetPublishAuditRequest extends TeaModel {
    @NameInMap("auditId")
    public String auditId;

    public static GetPublishAuditRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPublishAuditRequest self = new GetPublishAuditRequest();
        return TeaModel.build(map, self);
    }

    public GetPublishAuditRequest setAuditId(String auditId) {
        this.auditId = auditId;
        return this;
    }
    public String getAuditId() {
        return this.auditId;
    }

}
