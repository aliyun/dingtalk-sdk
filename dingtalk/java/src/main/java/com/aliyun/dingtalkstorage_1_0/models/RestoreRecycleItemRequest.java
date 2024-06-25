// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemRequest extends TeaModel {
    @NameInMap("option")
    public RestoreRecycleItemRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static RestoreRecycleItemRequest build(java.util.Map<String, ?> map) throws Exception {
        RestoreRecycleItemRequest self = new RestoreRecycleItemRequest();
        return TeaModel.build(map, self);
    }

    public RestoreRecycleItemRequest setOption(RestoreRecycleItemRequestOption option) {
        this.option = option;
        return this;
    }
    public RestoreRecycleItemRequestOption getOption() {
        return this.option;
    }

    public RestoreRecycleItemRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class RestoreRecycleItemRequestOption extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>AUTO_RENAME</p>
         */
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        public static RestoreRecycleItemRequestOption build(java.util.Map<String, ?> map) throws Exception {
            RestoreRecycleItemRequestOption self = new RestoreRecycleItemRequestOption();
            return TeaModel.build(map, self);
        }

        public RestoreRecycleItemRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

    }

}
