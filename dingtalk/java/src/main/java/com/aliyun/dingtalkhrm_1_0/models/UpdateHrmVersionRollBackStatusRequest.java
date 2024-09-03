// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateHrmVersionRollBackStatusRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>show</p>
     */
    @NameInMap("configValue")
    public String configValue;

    /**
     * <strong>example:</strong>
     * <p>1231231232</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    public static UpdateHrmVersionRollBackStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateHrmVersionRollBackStatusRequest self = new UpdateHrmVersionRollBackStatusRequest();
        return TeaModel.build(map, self);
    }

    public UpdateHrmVersionRollBackStatusRequest setConfigValue(String configValue) {
        this.configValue = configValue;
        return this;
    }
    public String getConfigValue() {
        return this.configValue;
    }

    public UpdateHrmVersionRollBackStatusRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

}
