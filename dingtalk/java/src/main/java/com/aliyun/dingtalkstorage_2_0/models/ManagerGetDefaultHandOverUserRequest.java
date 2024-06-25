// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ManagerGetDefaultHandOverUserRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static ManagerGetDefaultHandOverUserRequest build(java.util.Map<String, ?> map) throws Exception {
        ManagerGetDefaultHandOverUserRequest self = new ManagerGetDefaultHandOverUserRequest();
        return TeaModel.build(map, self);
    }

    public ManagerGetDefaultHandOverUserRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
