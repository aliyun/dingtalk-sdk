// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StartCloudRecordRequest extends TeaModel {
    // 录制模版
    @NameInMap("mode")
    public String mode;

    // 小窗位置
    @NameInMap("smallWindowPosition")
    public String smallWindowPosition;

    // 会议发起人UID
    @NameInMap("unionId")
    public String unionId;

    public static StartCloudRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        StartCloudRecordRequest self = new StartCloudRecordRequest();
        return TeaModel.build(map, self);
    }

    public StartCloudRecordRequest setMode(String mode) {
        this.mode = mode;
        return this;
    }
    public String getMode() {
        return this.mode;
    }

    public StartCloudRecordRequest setSmallWindowPosition(String smallWindowPosition) {
        this.smallWindowPosition = smallWindowPosition;
        return this;
    }
    public String getSmallWindowPosition() {
        return this.smallWindowPosition;
    }

    public StartCloudRecordRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
