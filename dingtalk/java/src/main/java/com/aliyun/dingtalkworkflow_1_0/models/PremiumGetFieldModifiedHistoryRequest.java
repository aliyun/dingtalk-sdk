// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetFieldModifiedHistoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>TextField-abcd</p>
     */
    @NameInMap("fieldId")
    public String fieldId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>proc-FF6Y2xxxx</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static PremiumGetFieldModifiedHistoryRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetFieldModifiedHistoryRequest self = new PremiumGetFieldModifiedHistoryRequest();
        return TeaModel.build(map, self);
    }

    public PremiumGetFieldModifiedHistoryRequest setFieldId(String fieldId) {
        this.fieldId = fieldId;
        return this;
    }
    public String getFieldId() {
        return this.fieldId;
    }

    public PremiumGetFieldModifiedHistoryRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
