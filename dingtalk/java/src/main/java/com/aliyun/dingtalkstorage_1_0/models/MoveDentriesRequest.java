// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentriesRequest extends TeaModel {
    // 源文件(夹)id列表
    // 最大size:
    // 	30
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    // 可选参数
    @NameInMap("option")
    public MoveDentriesRequestOption option;

    // 目标文件夹id, 根目录id值为0
    @NameInMap("targetFolderId")
    public String targetFolderId;

    // 目标文件(夹)空间id
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static MoveDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveDentriesRequest self = new MoveDentriesRequest();
        return TeaModel.build(map, self);
    }

    public MoveDentriesRequest setDentryIds(java.util.List<String> dentryIds) {
        this.dentryIds = dentryIds;
        return this;
    }
    public java.util.List<String> getDentryIds() {
        return this.dentryIds;
    }

    public MoveDentriesRequest setOption(MoveDentriesRequestOption option) {
        this.option = option;
        return this;
    }
    public MoveDentriesRequestOption getOption() {
        return this.option;
    }

    public MoveDentriesRequest setTargetFolderId(String targetFolderId) {
        this.targetFolderId = targetFolderId;
        return this;
    }
    public String getTargetFolderId() {
        return this.targetFolderId;
    }

    public MoveDentriesRequest setTargetSpaceId(String targetSpaceId) {
        this.targetSpaceId = targetSpaceId;
        return this;
    }
    public String getTargetSpaceId() {
        return this.targetSpaceId;
    }

    public MoveDentriesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class MoveDentriesRequestOption extends TeaModel {
        // 文件(夹)名称冲突策略
        // 枚举值:
        // 	AUTO_RENAME: 自动重命名
        // 	OVERWRITE: 覆盖
        // 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        // 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        // 默认值:
        // 	AUTO_RENAME
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        // 移动后，是否保留权限
        // 默认值:
        // 	false
        @NameInMap("preservePermissions")
        public Boolean preservePermissions;

        public static MoveDentriesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            MoveDentriesRequestOption self = new MoveDentriesRequestOption();
            return TeaModel.build(map, self);
        }

        public MoveDentriesRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

        public MoveDentriesRequestOption setPreservePermissions(Boolean preservePermissions) {
            this.preservePermissions = preservePermissions;
            return this;
        }
        public Boolean getPreservePermissions() {
            return this.preservePermissions;
        }

    }

}
