// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class MoveFileRequest extends TeaModel {
    /**
     * <p>文件名冲突策略</p>
     */
    @NameInMap("addConflictPolicy")
    public String addConflictPolicy;

    /**
     * <p>目标父目录id</p>
     */
    @NameInMap("targetParentId")
    public String targetParentId;

    /**
     * <p>目标空间id</p>
     */
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static MoveFileRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveFileRequest self = new MoveFileRequest();
        return TeaModel.build(map, self);
    }

    public MoveFileRequest setAddConflictPolicy(String addConflictPolicy) {
        this.addConflictPolicy = addConflictPolicy;
        return this;
    }
    public String getAddConflictPolicy() {
        return this.addConflictPolicy;
    }

    public MoveFileRequest setTargetParentId(String targetParentId) {
        this.targetParentId = targetParentId;
        return this;
    }
    public String getTargetParentId() {
        return this.targetParentId;
    }

    public MoveFileRequest setTargetSpaceId(String targetSpaceId) {
        this.targetSpaceId = targetSpaceId;
        return this;
    }
    public String getTargetSpaceId() {
        return this.targetSpaceId;
    }

    public MoveFileRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
