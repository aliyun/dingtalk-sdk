// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class ConfirmFirmwareUpgradeResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ConfirmFirmwareUpgradeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConfirmFirmwareUpgradeResponseBody self = new ConfirmFirmwareUpgradeResponseBody();
        return TeaModel.build(map, self);
    }

    public ConfirmFirmwareUpgradeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
