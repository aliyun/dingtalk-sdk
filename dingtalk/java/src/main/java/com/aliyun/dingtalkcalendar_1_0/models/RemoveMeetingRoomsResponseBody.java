// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class RemoveMeetingRoomsResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static RemoveMeetingRoomsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveMeetingRoomsResponseBody self = new RemoveMeetingRoomsResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveMeetingRoomsResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
