// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class ChangeSwitchResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enabled")
    public Boolean enabled;

    public static ChangeSwitchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChangeSwitchResponseBody self = new ChangeSwitchResponseBody();
        return TeaModel.build(map, self);
    }

    public ChangeSwitchResponseBody setEnabled(Boolean enabled) {
        this.enabled = enabled;
        return this;
    }
    public Boolean getEnabled() {
        return this.enabled;
    }

}
