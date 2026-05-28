// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdatePublishAuditResultResponseBody extends TeaModel {
    @NameInMap("accepted")
    public Boolean accepted;

    @NameInMap("auditId")
    public String auditId;

    @NameInMap("status")
    public String status;

    public static UpdatePublishAuditResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdatePublishAuditResultResponseBody self = new UpdatePublishAuditResultResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdatePublishAuditResultResponseBody setAccepted(Boolean accepted) {
        this.accepted = accepted;
        return this;
    }
    public Boolean getAccepted() {
        return this.accepted;
    }

    public UpdatePublishAuditResultResponseBody setAuditId(String auditId) {
        this.auditId = auditId;
        return this;
    }
    public String getAuditId() {
        return this.auditId;
    }

    public UpdatePublishAuditResultResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
