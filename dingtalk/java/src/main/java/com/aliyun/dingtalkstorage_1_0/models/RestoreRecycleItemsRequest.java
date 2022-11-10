// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemsRequest extends TeaModel {
    // 可选参数
    @NameInMap("option")
    public RestoreRecycleItemsRequestOption option;

    // 回收项id列表
    // 最大size:
    // 	30
    @NameInMap("recycleItemIds")
    public java.util.List<String> recycleItemIds;

    // 用户id
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
        // 文件名称冲突策略
        // 还原时原路径可能已经存在同名的文件
        // 枚举值:
        // 	AUTO_RENAME: 自动重命名
        // 	OVERWRITE: 覆盖
        // 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        // 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        // 默认值:
        // 	AUTO_RENAME
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
