// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class SignInResponseBody extends TeaModel {
    // 签到时间戳
    @NameInMap("checkInTime")
    public Long checkInTime;

    public static SignInResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SignInResponseBody self = new SignInResponseBody();
        return TeaModel.build(map, self);
    }

    public SignInResponseBody setCheckInTime(Long checkInTime) {
        this.checkInTime = checkInTime;
        return this;
    }
    public Long getCheckInTime() {
        return this.checkInTime;
    }

}
