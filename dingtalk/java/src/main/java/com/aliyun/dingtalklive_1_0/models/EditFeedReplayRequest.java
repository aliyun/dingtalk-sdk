// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class EditFeedReplayRequest extends TeaModel {
    @NameInMap("editEndTime")
    public Long editEndTime;

    @NameInMap("editStartTime")
    public Long editStartTime;

    @NameInMap("userId")
    public String userId;

    public static EditFeedReplayRequest build(java.util.Map<String, ?> map) throws Exception {
        EditFeedReplayRequest self = new EditFeedReplayRequest();
        return TeaModel.build(map, self);
    }

    public EditFeedReplayRequest setEditEndTime(Long editEndTime) {
        this.editEndTime = editEndTime;
        return this;
    }
    public Long getEditEndTime() {
        return this.editEndTime;
    }

    public EditFeedReplayRequest setEditStartTime(Long editStartTime) {
        this.editStartTime = editStartTime;
        return this;
    }
    public Long getEditStartTime() {
        return this.editStartTime;
    }

    public EditFeedReplayRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
