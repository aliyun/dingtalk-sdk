// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddFolderRequest extends TeaModel {
    /**
     * <p>名称(文件名+后缀), 规则：</p>
     * <p>1. 头尾不能包含空格，否则会自动去除</p>
     * <p>2. 不能包含特殊字符，包括：制表符、*、"、<、>、|</p>
     * <p>3. 不能以"."结尾</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public AddFolderRequestOption option;

    /**
     * <p>用户id</p>
     */
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

    public static class AddFolderRequestOptionAppProperties extends TeaModel {
        /**
         * <p>属性名称 该属性名称在当前app下需要保证唯一，不同app间同名属性互不影响</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>属性值</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>属性可见范围</p>
         * <p>枚举值:</p>
         * <p>	PUBLIC: 该属性所有App可见</p>
         * <p>	PRIVATE: 该属性仅其归属App可见</p>
         */
        @NameInMap("visibility")
        public String visibility;

        public static AddFolderRequestOptionAppProperties build(java.util.Map<String, ?> map) throws Exception {
            AddFolderRequestOptionAppProperties self = new AddFolderRequestOptionAppProperties();
            return TeaModel.build(map, self);
        }

        public AddFolderRequestOptionAppProperties setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddFolderRequestOptionAppProperties setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public AddFolderRequestOptionAppProperties setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

    public static class AddFolderRequestOption extends TeaModel {
        /**
         * <p>文件夹在应用上的属性, 一个应用最多只能设置3个属性</p>
         * <p>最大size:</p>
         * <p>	3</p>
         */
        @NameInMap("appProperties")
        public java.util.List<AddFolderRequestOptionAppProperties> appProperties;

        /**
         * <p>文件夹名称冲突策略</p>
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

        public static AddFolderRequestOption build(java.util.Map<String, ?> map) throws Exception {
            AddFolderRequestOption self = new AddFolderRequestOption();
            return TeaModel.build(map, self);
        }

        public AddFolderRequestOption setAppProperties(java.util.List<AddFolderRequestOptionAppProperties> appProperties) {
            this.appProperties = appProperties;
            return this;
        }
        public java.util.List<AddFolderRequestOptionAppProperties> getAppProperties() {
            return this.appProperties;
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
