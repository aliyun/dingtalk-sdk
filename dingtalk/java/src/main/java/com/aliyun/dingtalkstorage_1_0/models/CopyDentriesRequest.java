// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class CopyDentriesRequest extends TeaModel {
    /**
     * <p>源文件(夹)id列表</p>
     * <p>最大size:</p>
     * <p>	30</p>
     */
    @NameInMap("dentryIds")
    public java.util.List<String> dentryIds;

    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public CopyDentriesRequestOption option;

    /**
     * <p>目标文件夹id, 根目录id值为0</p>
     */
    @NameInMap("targetFolderId")
    public String targetFolderId;

    /**
     * <p>目标文件夹空间id</p>
     */
    @NameInMap("targetSpaceId")
    public String targetSpaceId;

    /**
     * <p>用户id</p>
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
         * <p>文件(夹)名称冲突策略</p>
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
