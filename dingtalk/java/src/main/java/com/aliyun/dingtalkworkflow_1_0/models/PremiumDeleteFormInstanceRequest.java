// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumDeleteFormInstanceRequest extends TeaModel {
    @NameInMap("formInstanceIds")
    public java.util.List<String> formInstanceIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PROC-EF6YJL35P2-SCKICSB7P750S0YISYKV3-xxxx-1</p>
     */
    @NameInMap("processCode")
    public String processCode;

    @NameInMap("userId")
    public String userId;

    public static PremiumDeleteFormInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumDeleteFormInstanceRequest self = new PremiumDeleteFormInstanceRequest();
        return TeaModel.build(map, self);
    }

    public PremiumDeleteFormInstanceRequest setFormInstanceIds(java.util.List<String> formInstanceIds) {
        this.formInstanceIds = formInstanceIds;
        return this;
    }
    public java.util.List<String> getFormInstanceIds() {
        return this.formInstanceIds;
    }

    public PremiumDeleteFormInstanceRequest setProcessCode(String processCode) {
        this.processCode = processCode;
        return this;
    }
    public String getProcessCode() {
        return this.processCode;
    }

    public PremiumDeleteFormInstanceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
