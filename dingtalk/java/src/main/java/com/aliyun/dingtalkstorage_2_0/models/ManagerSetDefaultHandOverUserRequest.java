// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ManagerSetDefaultHandOverUserRequest extends TeaModel {
    @NameInMap("defaultHandoverUserId")
    public String defaultHandoverUserId;

    @NameInMap("operatorId")
    public String operatorId;

    public static ManagerSetDefaultHandOverUserRequest build(java.util.Map<String, ?> map) throws Exception {
        ManagerSetDefaultHandOverUserRequest self = new ManagerSetDefaultHandOverUserRequest();
        return TeaModel.build(map, self);
    }

    public ManagerSetDefaultHandOverUserRequest setDefaultHandoverUserId(String defaultHandoverUserId) {
        this.defaultHandoverUserId = defaultHandoverUserId;
        return this;
    }
    public String getDefaultHandoverUserId() {
        return this.defaultHandoverUserId;
    }

    public ManagerSetDefaultHandOverUserRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
