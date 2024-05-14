// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentryRequest extends TeaModel {
    @NameInMap("option")
    public MoveDentryRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetFolderId")
    public String targetFolderId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    /**
     * <p>This parameter is required.</p>
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
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

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
