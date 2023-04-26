// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemsRequest extends TeaModel {
    @NameInMap("option")
    public RestoreRecycleItemsRequestOption option;

    @NameInMap("recycleItemIds")
    public java.util.List<String> recycleItemIds;

    @NameInMap("unionId")
    public String unionId;

    public static RestoreRecycleItemsRequest build(java.util.Map<String, ?> map) throws Exception {
        RestoreRecycleItemsRequest self = new RestoreRecycleItemsRequest();
        return TeaModel.build(map, self);
    }

    public RestoreRecycleItemsRequest setOption(RestoreRecycleItemsRequestOption option) {
        this.option = option;
        return this;
    }
    public RestoreRecycleItemsRequestOption getOption() {
        return this.option;
    }

    public RestoreRecycleItemsRequest setRecycleItemIds(java.util.List<String> recycleItemIds) {
        this.recycleItemIds = recycleItemIds;
        return this;
    }
    public java.util.List<String> getRecycleItemIds() {
        return this.recycleItemIds;
    }

    public RestoreRecycleItemsRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class RestoreRecycleItemsRequestOption extends TeaModel {
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        public static RestoreRecycleItemsRequestOption build(java.util.Map<String, ?> map) throws Exception {
            RestoreRecycleItemsRequestOption self = new RestoreRecycleItemsRequestOption();
            return TeaModel.build(map, self);
        }

        public RestoreRecycleItemsRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

    }

}
