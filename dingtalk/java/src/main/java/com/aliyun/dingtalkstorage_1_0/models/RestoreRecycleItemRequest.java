// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemRequest extends TeaModel {
    // 可选参数
    @NameInMap("option")
    public RestoreRecycleItemRequestOption option;

    // 用户id
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
