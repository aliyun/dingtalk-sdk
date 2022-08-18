// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddFolderRequest extends TeaModel {
    // 名称(文件名+后缀), 规则：
    // 1. 头尾不能包含空格，否则会自动去除
    // 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
    // 3. 不能以"."结尾
    @NameInMap("name")
    public String name;

    // 可选参数
    @NameInMap("option")
    public AddFolderRequestOption option;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static AddFolderRequest build(java.util.Map<String, ?> map) throws Exception {
        AddFolderRequest self = new AddFolderRequest();
        return TeaModel.build(map, self);
    }

    public AddFolderRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddFolderRequest setOption(AddFolderRequestOption option) {
        this.option = option;
        return this;
    }
    public AddFolderRequestOption getOption() {
        return this.option;
    }

    public AddFolderRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class AddFolderRequestOption extends TeaModel {
        // 文件夹名称冲突策略
        // 枚举值:
        // 	AUTO_RENAME: 自动重命名
        // 	OVERWRITE: 覆盖
        // 	RETURN_DENTRY_IF_EXISTS: 返回已存在文件
        // 	RETURN_ERROR_IF_EXISTS: 文件已存在时报错
        // 默认值:
        // 	AUTO_RENAME
        @NameInMap("conflictStrategy")
        public String conflictStrategy;

        public static AddFolderRequestOption build(java.util.Map<String, ?> map) throws Exception {
            AddFolderRequestOption self = new AddFolderRequestOption();
            return TeaModel.build(map, self);
        }

        public AddFolderRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

    }

}
