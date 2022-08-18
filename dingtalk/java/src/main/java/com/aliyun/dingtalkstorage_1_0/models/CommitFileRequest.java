// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class CommitFileRequest extends TeaModel {
    // 名称(文件名+后缀), 规则：
    // 1. 头尾不能包含空格，否则会自动去除
    // 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
    // 3. 不能以"."结尾
    @NameInMap("name")
    public String name;

    // 可选参数
    @NameInMap("option")
    public CommitFileRequestOption option;

    // 父目录id, 根目录id值为0
    @NameInMap("parentId")
    public String parentId;

    // 添加文件唯一标识，可通过DentryService.getUploadInfo来生成
    @NameInMap("uploadKey")
    public String uploadKey;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static CommitFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CommitFileRequest self = new CommitFileRequest();
        return TeaModel.build(map, self);
    }

    public CommitFileRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CommitFileRequest setOption(CommitFileRequestOption option) {
        this.option = option;
        return this;
    }
    public CommitFileRequestOption getOption() {
        return this.option;
    }

    public CommitFileRequest setParentId(String parentId) {
        this.parentId = parentId;
        return this;
    }
    public String getParentId() {
        return this.parentId;
    }

    public CommitFileRequest setUploadKey(String uploadKey) {
        this.uploadKey = uploadKey;
        return this;
    }
    public String getUploadKey() {
        return this.uploadKey;
    }

    public CommitFileRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class CommitFileRequestOption extends TeaModel {
        // 文件名称冲突策略
        // 枚举值:
        // 	AUTO_RENAME: 自动重命名
        // 	OVERWRITE: 覆盖
        // 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        // 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        // 默认值:
        // 	AUTO_RENAME
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        // 默认文件大小, 单位:Byte
        // 如果此字段不为空，企业存储系统会校验文件实际大小是否和此字段是否一致，不一致会报错
        @NameInMap("size")
        public Long size;

        public static CommitFileRequestOption build(java.util.Map<String, ?> map) throws Exception {
            CommitFileRequestOption self = new CommitFileRequestOption();
            return TeaModel.build(map, self);
        }

        public CommitFileRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

        public CommitFileRequestOption setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

    }

}
