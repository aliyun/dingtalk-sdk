// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentryRequest extends TeaModel {
    // 可选参数
    @NameInMap("option")
    public MoveDentryRequestOption option;

    // 目标文件夹ID
    @NameInMap("targetFolderId")
    public String targetFolderId;

    // 目标文件(夹)空间id
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static MoveDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        MoveDentryRequest self = new MoveDentryRequest();
        return TeaModel.build(map, self);
    }

    public MoveDentryRequest setOption(MoveDentryRequestOption option) {
        this.option = option;
        return this;
    }
    public MoveDentryRequestOption getOption() {
        return this.option;
    }

    public MoveDentryRequest setTargetFolderId(String targetFolderId) {
        this.targetFolderId = targetFolderId;
        return this;
    }
    public String getTargetFolderId() {
        return this.targetFolderId;
    }

    public MoveDentryRequest setTargetSpaceId(String targetSpaceId) {
        this.targetSpaceId = targetSpaceId;
        return this;
    }
    public String getTargetSpaceId() {
        return this.targetSpaceId;
    }

    public MoveDentryRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class MoveDentryRequestOption extends TeaModel {
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
        @NameInMap("presevePermissions")
        public Boolean presevePermissions;

        public static MoveDentryRequestOption build(java.util.Map<String, ?> map) throws Exception {
            MoveDentryRequestOption self = new MoveDentryRequestOption();
            return TeaModel.build(map, self);
        }

        public MoveDentryRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

        public MoveDentryRequestOption setPresevePermissions(Boolean presevePermissions) {
            this.presevePermissions = presevePermissions;
            return this;
        }
        public Boolean getPresevePermissions() {
            return this.presevePermissions;
        }

    }

}
