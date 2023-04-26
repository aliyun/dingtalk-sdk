// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class ActivateDeviceResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ActivateDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ActivateDeviceResponseBody self = new ActivateDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public ActivateDeviceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
