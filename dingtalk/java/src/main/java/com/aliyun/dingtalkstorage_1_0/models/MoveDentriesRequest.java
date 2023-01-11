// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentriesRequest extends TeaModel {
    /**
     * <p>源文件(夹)id列表</p>
     * <p>最大size:</p>
     * <p>	30</p>
     */
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public MoveDentriesRequestOption option;

    /**
     * <p>目标文件夹id, 根目录id值为0</p>
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
