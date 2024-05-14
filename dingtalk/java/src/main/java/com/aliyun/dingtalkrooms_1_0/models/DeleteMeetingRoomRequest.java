// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteMeetingRoomRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static DeleteMeetingRoomRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMeetingRoomRequest self = new DeleteMeetingRoomRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMeetingRoomRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
