// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class CopyDentriesRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    @NameInMap("option")
    public CopyDentriesRequestOption option;

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

    public static CopyDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyDentriesRequest self = new CopyDentriesRequest();
        return TeaModel.build(map, self);
    }

    public CopyDentriesRequest setDentryIds(java.util.List<String> dentryIds) {
        this.dentryIds = dentryIds;
        return this;
    }
    public java.util.List<String> getDentryIds() {
        return this.dentryIds;
    }

    public CopyDentriesRequest setOption(CopyDentriesRequestOption option) {
        this.option = option;
        return this;
    }
    public CopyDentriesRequestOption getOption() {
        return this.option;
    }

    public CopyDentriesRequest setTargetFolderId(String targetFolderId) {
        this.targetFolderId = targetFolderId;
        return this;
    }
    public String getTargetFolderId() {
        return this.targetFolderId;
    }

    public CopyDentriesRequest setTargetSpaceId(String targetSpaceId) {
        this.targetSpaceId = targetSpaceId;
        return this;
    }
    public String getTargetSpaceId() {
        return this.targetSpaceId;
    }

    public CopyDentriesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CopyDentriesRequestOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>AUTO_RENAME</p>
         */
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        public static CopyDentriesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            CopyDentriesRequestOption self = new CopyDentriesRequestOption();
            return TeaModel.build(map, self);
        }

        public CopyDentriesRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

    }

}
