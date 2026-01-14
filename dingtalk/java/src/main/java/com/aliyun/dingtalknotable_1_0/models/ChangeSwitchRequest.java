// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ChangeSwitchRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("value")
    public Boolean value;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static ChangeSwitchRequest build(java.util.Map<String, ?> map) throws Exception {
        ChangeSwitchRequest self = new ChangeSwitchRequest();
        return TeaModel.build(map, self);
    }

    public ChangeSwitchRequest setValue(Boolean value) {
        this.value = value;
        return this;
    }
    public Boolean getValue() {
        return this.value;
    }

    public ChangeSwitchRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
