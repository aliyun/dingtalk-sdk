// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetFieldModifiedHistoryRequest extends TeaModel {
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

    public static GetFieldModifiedHistoryRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFieldModifiedHistoryRequest self = new GetFieldModifiedHistoryRequest();
        return TeaModel.build(map, self);
    }

    public GetFieldModifiedHistoryRequest setFieldId(String fieldId) {
        this.fieldId = fieldId;
        return this;
    }
    public String getFieldId() {
        return this.fieldId;
    }

    public GetFieldModifiedHistoryRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
