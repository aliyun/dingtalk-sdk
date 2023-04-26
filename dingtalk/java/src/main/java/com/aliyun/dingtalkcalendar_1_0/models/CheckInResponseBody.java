// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CheckInResponseBody extends TeaModel {
    @NameInMap("checkInTime")
    public Long checkInTime;

    public static CheckInResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckInResponseBody self = new CheckInResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckInResponseBody setCheckInTime(Long checkInTime) {
        this.checkInTime = checkInTime;
        return this;
    }
    public Long getCheckInTime() {
        return this.checkInTime;
    }

}
