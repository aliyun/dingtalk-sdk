// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateSubscribedCalendarResponseBody extends TeaModel {
    // 日历id
    @NameInMap("calendarId")
    public String calendarId;

    public static CreateSubscribedCalendarResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateSubscribedCalendarResponseBody self = new CreateSubscribedCalendarResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateSubscribedCalendarResponseBody setCalendarId(String calendarId) {
        this.calendarId = calendarId;
        return this;
    }
    public String getCalendarId() {
        return this.calendarId;
    }

}
