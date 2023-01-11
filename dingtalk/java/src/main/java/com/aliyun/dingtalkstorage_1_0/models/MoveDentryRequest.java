// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentryRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public MoveDentryRequestOption option;

    /**
     * <p>目标文件夹ID</p>
     */
    @NameInMap("targetFolderId")
    public String targetFolderId;

    /**
     * <p>目标文件(夹)空间id</p>
     */
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    /**
     * <p>用户id</p>
     */
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
        /**
         * <p>文件(夹)名称冲突策略</p>
         * <p>枚举值:</p>
         * <p>	AUTO_RENAME: 自动重命名</p>
         * <p>	OVERWRITE: 覆盖</p>
         * <p>	RETURN_DENTRY_IF_EXISTS: 返回已存在文件</p>
         * <p>	RETURN_ERROR_IF_EXISTS: 文件已存在时报错</p>
         * <p>默认值:</p>
         * <p>	AUTO_RENAME</p>
         */
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        /**
         * <p>移动后，是否保留权限</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
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
