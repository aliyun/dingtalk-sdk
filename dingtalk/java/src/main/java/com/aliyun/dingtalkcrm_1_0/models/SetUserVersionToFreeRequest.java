// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SetUserVersionToFreeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>012829186736-1115677667</p>
     */
    @NameInMap("operatorUserId")
    public String operatorUserId;

    public static SetUserVersionToFreeRequest build(java.util.Map<String, ?> map) throws Exception {
        SetUserVersionToFreeRequest self = new SetUserVersionToFreeRequest();
        return TeaModel.build(map, self);
    }

    public SetUserVersionToFreeRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

}
