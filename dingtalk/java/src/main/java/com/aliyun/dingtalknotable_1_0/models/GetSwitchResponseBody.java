// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetSwitchResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("enabled")
    public Boolean enabled;

    public static GetSwitchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSwitchResponseBody self = new GetSwitchResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSwitchResponseBody setEnabled(Boolean enabled) {
        this.enabled = enabled;
        return this;
    }
    public Boolean getEnabled() {
        return this.enabled;
    }

}
