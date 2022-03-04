// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitDeviceResponseBody extends TeaModel {
    // 成功信息
    @NameInMap("successInfo")
    public Boolean successInfo;

    public static InitDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InitDeviceResponseBody self = new InitDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public InitDeviceResponseBody setSuccessInfo(Boolean successInfo) {
        this.successInfo = successInfo;
        return this;
    }
    public Boolean getSuccessInfo() {
        return this.successInfo;
    }

}
