// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveOpenTerminalInfoResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SaveOpenTerminalInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveOpenTerminalInfoResponseBody self = new SaveOpenTerminalInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveOpenTerminalInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
