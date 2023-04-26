// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentriesRequest extends TeaModel {
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    @NameInMap("option")
    public MoveDentriesRequestOption option;

    @NameInMap("targetFolderId")
    public String targetFolderId;

    @NameInMap("targetSpaceId")
    public String targetSpaceId;

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
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

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
