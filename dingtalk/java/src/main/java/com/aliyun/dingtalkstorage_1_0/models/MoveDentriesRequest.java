// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentriesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    @NameInMap("option")
    public MoveDentriesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>target_folder_id</p>
     */
    @NameInMap("targetFolderId")
    public String targetFolderId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>target_space_id</p>
     */
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
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
         * <strong>example:</strong>
         * <p>AUTO_RENAME</p>
         */
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        /**
         * <strong>example:</strong>
         * <p>true</p>
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
