// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateMeetingRoomControlPanelResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static CreateMeetingRoomControlPanelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateMeetingRoomControlPanelResponseBody self = new CreateMeetingRoomControlPanelResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateMeetingRoomControlPanelResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
