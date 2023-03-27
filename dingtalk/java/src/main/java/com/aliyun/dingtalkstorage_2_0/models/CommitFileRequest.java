// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class CommitFileRequest extends TeaModel {
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
    public CommitFileRequestOption option;

    /**
     * <p>添加文件唯一标识，可通过DentryService.getUploadInfo来生成</p>
     */
    @NameInMap("uploadKey")
    public String uploadKey;

    /**
     * <p>用户id</p>
     */
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

    public static class CommitFileRequestOptionAppProperties extends TeaModel {
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

        public static CommitFileRequestOptionAppProperties build(java.util.Map<String, ?> map) throws Exception {
            CommitFileRequestOptionAppProperties self = new CommitFileRequestOptionAppProperties();
            return TeaModel.build(map, self);
        }

        public CommitFileRequestOptionAppProperties setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CommitFileRequestOptionAppProperties setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public CommitFileRequestOptionAppProperties setVisibility(String visibility) {
            this.visibility = visibility;
            return this;
        }
        public String getVisibility() {
            return this.visibility;
        }

    }

    public static class CommitFileRequestOption extends TeaModel {
        /**
         * <p>文件在应用上的属性, 一个应用最多只能设置3个属性</p>
         * <p>最大size:</p>
         * <p>	3</p>
         */
        @NameInMap("appProperties")
        public java.util.List<CommitFileRequestOptionAppProperties> appProperties;

        /**
         * <p>文件名称冲突策略</p>
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

        /**
         * <p>是否转换成在线文档</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("convertToOnlineDoc")
        public Boolean convertToOnlineDoc;

        /**
         * <p>默认文件大小, 单位:Byte</p>
         * <p>如果此字段不为空，企业存储系统会校验文件实际大小是否和此字段是否一致，不一致会报错</p>
         */
        @NameInMap("size")
        public Long size;

        public static CommitFileRequestOption build(java.util.Map<String, ?> map) throws Exception {
            CommitFileRequestOption self = new CommitFileRequestOption();
            return TeaModel.build(map, self);
        }

        public CommitFileRequestOption setAppProperties(java.util.List<CommitFileRequestOptionAppProperties> appProperties) {
            this.appProperties = appProperties;
            return this;
        }
        public java.util.List<CommitFileRequestOptionAppProperties> getAppProperties() {
            return this.appProperties;
        }

        public CommitFileRequestOption setConflictStrategy(String conflictStrategy) {
            this.conflictStrategy = conflictStrategy;
            return this;
        }
        public String getConflictStrategy() {
            return this.conflictStrategy;
        }

        public CommitFileRequestOption setConvertToOnlineDoc(Boolean convertToOnlineDoc) {
            this.convertToOnlineDoc = convertToOnlineDoc;
            return this;
        }
        public Boolean getConvertToOnlineDoc() {
            return this.convertToOnlineDoc;
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
