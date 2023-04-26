// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class CopyDentryRequest extends TeaModel {
    @NameInMap("option")
    public CopyDentryRequestOption option;

    @NameInMap("targetFolderId")
    public String targetFolderId;

    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    @NameInMap("unionId")
    public String unionId;

    public static CopyDentryRequest build(java.util.Map<String, ?> map) throws Exception {
        CopyDentryRequest self = new CopyDentryRequest();
        return TeaModel.build(map, self);
    }

    public CopyDentryRequest setOption(CopyDentryRequestOption option) {
        this.option = option;
        return this;
    }
    public CopyDentryRequestOption getOption() {
        return this.option;
    }

    public CopyDentryRequest setTargetFolderId(String targetFolderId) {
        this.targetFolderId = targetFolderId;
        return this;
    }
    public String getTargetFolderId() {
        return this.targetFolderId;
    }

    public CopyDentryRequest setTargetSpaceId(String targetSpaceId) {
        this.targetSpaceId = targetSpaceId;
        return this;
    }
    public String getTargetSpaceId() {
        return this.targetSpaceId;
    }

    public CopyDentryRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CopyDentryRequestOption extends TeaModel {
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        public static CopyDentryRequestOption build(java.util.Map<String, ?> map) throws Exception {
            CopyDentryRequestOption self = new CopyDentryRequestOption();
            return TeaModel.build(map, self);
        }

        public CopyDentryRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

    }

}
