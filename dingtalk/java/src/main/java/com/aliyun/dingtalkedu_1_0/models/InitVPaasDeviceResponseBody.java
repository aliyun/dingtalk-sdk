// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitVPaasDeviceResponseBody extends TeaModel {
    @NameInMap("pspk")
    public String pspk;

    public static InitVPaasDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InitVPaasDeviceResponseBody self = new InitVPaasDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public InitVPaasDeviceResponseBody setPspk(String pspk) {
        this.pspk = pspk;
        return this;
    }
    public String getPspk() {
        return this.pspk;
    }

}
