// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdatePublishAuditResultRequest extends TeaModel {
    @NameInMap("agentId")
    public String agentId;

    @NameInMap("auditId")
    public String auditId;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("rejectReason")
    public String rejectReason;

    @NameInMap("status")
    public Integer status;

    @NameInMap("versionId")
    public String versionId;

    public static UpdatePublishAuditResultRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePublishAuditResultRequest self = new UpdatePublishAuditResultRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePublishAuditResultRequest setAgentId(String agentId) {
        this.agentId = agentId;
        return this;
    }
    public String getAgentId() {
        return this.agentId;
    }

    public UpdatePublishAuditResultRequest setAuditId(String auditId) {
        this.auditId = auditId;
        return this;
    }
    public String getAuditId() {
        return this.auditId;
    }

    public UpdatePublishAuditResultRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public UpdatePublishAuditResultRequest setRejectReason(String rejectReason) {
        this.rejectReason = rejectReason;
        return this;
    }
    public String getRejectReason() {
        return this.rejectReason;
    }

    public UpdatePublishAuditResultRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public UpdatePublishAuditResultRequest setVersionId(String versionId) {
        this.versionId = versionId;
        return this;
    }
    public String getVersionId() {
        return this.versionId;
    }

}
