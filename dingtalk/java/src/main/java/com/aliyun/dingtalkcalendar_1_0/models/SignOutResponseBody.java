// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class SignOutResponseBody extends TeaModel {
    /**
     * <p>签退时间戳</p>
     */
    @NameInMap("checkOutTime")
    public Long checkOutTime;

    public static SignOutResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SignOutResponseBody self = new SignOutResponseBody();
        return TeaModel.build(map, self);
    }

    public SignOutResponseBody setCheckOutTime(Long checkOutTime) {
        this.checkOutTime = checkOutTime;
        return this;
    }
    public Long getCheckOutTime() {
        return this.checkOutTime;
    }

}
