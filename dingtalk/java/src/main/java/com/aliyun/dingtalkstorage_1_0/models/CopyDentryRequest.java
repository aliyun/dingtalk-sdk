// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class CopyDentryRequest extends TeaModel {
    // 可选参数
    @NameInMap("option")
    public CopyDentryRequestOption option;

    // 目标文件夹id, 根目录id值为0
    @NameInMap("targetFolderId")
    public String targetFolderId;

    // 目标文件夹空间id
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    // 用户id
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
        // 文件(夹)名称冲突策略
        // 枚举值:
        // 	AUTO_RENAME: 自动重命名
        // 	OVERWRITE: 覆盖
        // 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        // 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        // 默认值:
        // 	AUTO_RENAME
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
