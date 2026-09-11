// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateDeviceCutCustomerSwitchRequest extends TeaModel {
    @NameInMap("enabled")
    public Boolean enabled;

    @NameInMap("snList")
    public java.util.List<String> snList;

    public static BatchUpdateDeviceCutCustomerSwitchRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateDeviceCutCustomerSwitchRequest self = new BatchUpdateDeviceCutCustomerSwitchRequest();
        return TeaModel.build(map, self);
    }

    public BatchUpdateDeviceCutCustomerSwitchRequest setEnabled(Boolean enabled) {
        this.enabled = enabled;
        return this;
    }
    public Boolean getEnabled() {
        return this.enabled;
    }

    public BatchUpdateDeviceCutCustomerSwitchRequest setSnList(java.util.List<String> snList) {
        this.snList = snList;
        return this;
    }
    public java.util.List<String> getSnList() {
        return this.snList;
    }

}
