// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetInstFieldSettingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>proc-FF6Y2xxxx</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>userId123</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PremiumGetInstFieldSettingRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetInstFieldSettingRequest self = new PremiumGetInstFieldSettingRequest();
        return TeaModel.build(map, self);
    }

    public PremiumGetInstFieldSettingRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public PremiumGetInstFieldSettingRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
