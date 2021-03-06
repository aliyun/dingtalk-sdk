// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class AddAttendeeRequest extends TeaModel {
    @NameInMap("attendeesToAdd")
    public java.util.List<AddAttendeeRequestAttendeesToAdd> attendeesToAdd;

    public static AddAttendeeRequest build(java.util.Map<String, ?> map) throws Exception {
        AddAttendeeRequest self = new AddAttendeeRequest();
        return TeaModel.build(map, self);
    }

    public AddAttendeeRequest setAttendeesToAdd(java.util.List<AddAttendeeRequestAttendeesToAdd> attendeesToAdd) {
        this.attendeesToAdd = attendeesToAdd;
        return this;
    }
    public java.util.List<AddAttendeeRequestAttendeesToAdd> getAttendeesToAdd() {
        return this.attendeesToAdd;
    }

    public static class AddAttendeeRequestAttendeesToAdd extends TeaModel {
        @NameInMap("id")
        public String id;

        public static AddAttendeeRequestAttendeesToAdd build(java.util.Map<String, ?> map) throws Exception {
            AddAttendeeRequestAttendeesToAdd self = new AddAttendeeRequestAttendeesToAdd();
            return TeaModel.build(map, self);
        }

        public AddAttendeeRequestAttendeesToAdd setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

    }

}
