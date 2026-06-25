// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class ConfirmFirmwareUpgradeRequest extends TeaModel {
    @NameInMap("moduleName")
    public String moduleName;

    public static ConfirmFirmwareUpgradeRequest build(java.util.Map<String, ?> map) throws Exception {
        ConfirmFirmwareUpgradeRequest self = new ConfirmFirmwareUpgradeRequest();
        return TeaModel.build(map, self);
    }

    public ConfirmFirmwareUpgradeRequest setModuleName(String moduleName) {
        this.moduleName = moduleName;
        return this;
    }
    public String getModuleName() {
        return this.moduleName;
    }

}
