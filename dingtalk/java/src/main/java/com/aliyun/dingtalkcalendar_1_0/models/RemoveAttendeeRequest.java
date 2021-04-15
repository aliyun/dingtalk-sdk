// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class RemoveAttendeeRequest extends TeaModel {
    @NameInMap("attendeesToRemove")
    public java.util.List<RemoveAttendeeRequestAttendeesToRemove> attendeesToRemove;

    public static RemoveAttendeeRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveAttendeeRequest self = new RemoveAttendeeRequest();
        return TeaModel.build(map, self);
    }

    public RemoveAttendeeRequest setAttendeesToRemove(java.util.List<RemoveAttendeeRequestAttendeesToRemove> attendeesToRemove) {
        this.attendeesToRemove = attendeesToRemove;
        return this;
    }
    public java.util.List<RemoveAttendeeRequestAttendeesToRemove> getAttendeesToRemove() {
        return this.attendeesToRemove;
    }

    public static class RemoveAttendeeRequestAttendeesToRemove extends TeaModel {
        @NameInMap("id")
        public String id;

        public static RemoveAttendeeRequestAttendeesToRemove build(java.util.Map<String, ?> map) throws Exception {
            RemoveAttendeeRequestAttendeesToRemove self = new RemoveAttendeeRequestAttendeesToRemove();
            return TeaModel.build(map, self);
        }

        public RemoveAttendeeRequestAttendeesToRemove setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
