// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class MoveFileRequest extends TeaModel {
    // 目标空间id
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    // 目标父目录id
    @NameInMap("targetParentId")
    public String targetParentId;

    // 文件名冲突策略
    @NameInMap("addConflictPolicy")
    public String addConflictPolicy;

    public static MoveFileRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveFileRequest self = new MoveFileRequest();
        return TeaModel.build(map, self);
    }

    public MoveFileRequest setTargetSpaceId(String targetSpaceId) {
        this.targetSpaceId = targetSpaceId;
        return this;
    }
    public String getTargetSpaceId() {
        return this.targetSpaceId;
    }

    public MoveFileRequest setTargetParentId(String targetParentId) {
        this.targetParentId = targetParentId;
        return this;
    }
    public String getTargetParentId() {
        return this.targetParentId;
    }

    public MoveFileRequest setAddConflictPolicy(String addConflictPolicy) {
        this.addConflictPolicy = addConflictPolicy;
        return this;
    }
    public String getAddConflictPolicy() {
        return this.addConflictPolicy;
    }

}
