// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class MoveFilesRequest extends TeaModel {
    @NameInMap("addConflictPolicy")
    public String addConflictPolicy;

    @NameInMap("fileIds")
    public java.util.List<String> fileIds;

    @NameInMap("targetParentId")
    public String targetParentId;

    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    @NameInMap("unionId")
    public String unionId;

    public static MoveFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveFilesRequest self = new MoveFilesRequest();
        return TeaModel.build(map, self);
    }

    public MoveFilesRequest setAddConflictPolicy(String addConflictPolicy) {
        this.addConflictPolicy = addConflictPolicy;
        return this;
    }
    public String getAddConflictPolicy() {
        return this.addConflictPolicy;
    }

    public MoveFilesRequest setFileIds(java.util.List<String> fileIds) {
        this.fileIds = fileIds;
        return this;
    }
    public java.util.List<String> getFileIds() {
        return this.fileIds;
    }

    public MoveFilesRequest setTargetParentId(String targetParentId) {
        this.targetParentId = targetParentId;
        return this;
    }
    public String getTargetParentId() {
        return this.targetParentId;
    }

    public MoveFilesRequest setTargetSpaceId(String targetSpaceId) {
        this.targetSpaceId = targetSpaceId;
        return this;
    }
    public String getTargetSpaceId() {
        return this.targetSpaceId;
    }

    public MoveFilesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
