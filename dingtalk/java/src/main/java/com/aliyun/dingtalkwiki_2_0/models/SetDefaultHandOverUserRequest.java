// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class SetDefaultHandOverUserRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>staff_id</p>
     */
    @NameInMap("defaultHandoverUserId")
    public String defaultHandoverUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static SetDefaultHandOverUserRequest build(java.util.Map<String, ?> map) throws Exception {
        SetDefaultHandOverUserRequest self = new SetDefaultHandOverUserRequest();
        return TeaModel.build(map, self);
    }

    public SetDefaultHandOverUserRequest setDefaultHandoverUserId(String defaultHandoverUserId) {
        this.defaultHandoverUserId = defaultHandoverUserId;
        return this;
    }
    public String getDefaultHandoverUserId() {
        return this.defaultHandoverUserId;
    }

    public SetDefaultHandOverUserRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
