// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeCalendarResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UnsubscribeCalendarResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnsubscribeCalendarResponseBody self = new UnsubscribeCalendarResponseBody();
        return TeaModel.build(map, self);
    }

    public UnsubscribeCalendarResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
