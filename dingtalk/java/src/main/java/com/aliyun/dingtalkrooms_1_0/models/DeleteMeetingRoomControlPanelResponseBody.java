// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomControlPanelResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static DeleteMeetingRoomControlPanelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomControlPanelResponseBody self = new DeleteMeetingRoomControlPanelResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomControlPanelResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
