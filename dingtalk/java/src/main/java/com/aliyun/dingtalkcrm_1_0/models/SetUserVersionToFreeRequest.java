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

    /**
     * <strong>example:</strong>
     * <p>other</p>
     */
    @NameInMap("version")
    public String version;

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

    public SetUserVersionToFreeRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
