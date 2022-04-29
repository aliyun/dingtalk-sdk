// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class UpdateSubscribedCalendarsResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateSubscribedCalendarsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateSubscribedCalendarsResponseBody self = new UpdateSubscribedCalendarsResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateSubscribedCalendarsResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
