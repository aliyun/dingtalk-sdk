// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemsRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public RestoreRecycleItemsRequestOption option;

    /**
     * <p>回收项id列表</p>
     * <p>最大size:</p>
     * <p>	30</p>
     */
    @NameInMap("recycleItemIds")
    public java.util.List<String> recycleItemIds;

    /**
     * <p>用户id</p>
     */
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
        /**
         * <p>文件名称冲突策略</p>
         * <p>还原时原路径可能已经存在同名的文件</p>
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
