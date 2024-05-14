// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomControlPanelShrinkRequest extends TeaModel {
    @NameInMap("body")
    public String bodyShrink;

    public static DeleteMeetingRoomControlPanelShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomControlPanelShrinkRequest self = new DeleteMeetingRoomControlPanelShrinkRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomControlPanelShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
