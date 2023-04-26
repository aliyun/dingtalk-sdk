// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomGroupRequest extends TeaModel {
    @NameInMap("unionId")
    public String unionId;

    public static DeleteMeetingRoomGroupRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomGroupRequest self = new DeleteMeetingRoomGroupRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomGroupRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
