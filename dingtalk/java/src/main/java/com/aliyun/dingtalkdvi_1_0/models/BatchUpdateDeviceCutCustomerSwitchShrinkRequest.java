// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateDeviceCutCustomerSwitchShrinkRequest extends TeaModel {
    @NameInMap("enabled")
    public Boolean enabled;

    @NameInMap("snList")
    public String snListShrink;

    public static BatchUpdateDeviceCutCustomerSwitchShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateDeviceCutCustomerSwitchShrinkRequest self = new BatchUpdateDeviceCutCustomerSwitchShrinkRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateDeviceCutCustomerSwitchShrinkRequest setEnabled(Boolean enabled) {
        this.enabled = enabled;
        return this;
    }
    public Boolean getEnabled() {
        return this.enabled;
    }

    public BatchUpdateDeviceCutCustomerSwitchShrinkRequest setSnListShrink(String snListShrink) {
        this.snListShrink = snListShrink;
        return this;
    }
    public String getSnListShrink() {
        return this.snListShrink;
    }

}
