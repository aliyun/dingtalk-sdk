// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeactivateDeviceResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("activateTimes")
    public Integer activateTimes;

    public static DeactivateDeviceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeactivateDeviceResponseBody self = new DeactivateDeviceResponseBody();
        return TeaModel.build(map, self);
    }

    public DeactivateDeviceResponseBody setActivateTimes(Integer activateTimes) {
        this.activateTimes = activateTimes;
        return this;
    }
    public Integer getActivateTimes() {
        return this.activateTimes;
    }

}
