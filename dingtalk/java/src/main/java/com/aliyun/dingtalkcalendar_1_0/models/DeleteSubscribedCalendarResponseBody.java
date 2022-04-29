// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class DeleteSubscribedCalendarResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteSubscribedCalendarResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteSubscribedCalendarResponseBody self = new DeleteSubscribedCalendarResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteSubscribedCalendarResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
