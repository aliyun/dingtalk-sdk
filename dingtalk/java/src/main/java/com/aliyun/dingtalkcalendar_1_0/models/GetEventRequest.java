// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class GetEventRequest extends TeaModel {
    // 返回参与人，上限500人，默认为0
    @NameInMap("maxAttendees")
    public Long maxAttendees;

    public static GetEventRequest build(java.util.Map<String, ?> map) throws Exception {
        GetEventRequest self = new GetEventRequest();
        return TeaModel.build(map, self);
    }

    public GetEventRequest setMaxAttendees(Long maxAttendees) {
        this.maxAttendees = maxAttendees;
        return this;
    }
    public Long getMaxAttendees() {
        return this.maxAttendees;
    }

}
