// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddFolderRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dentry_name</p>
     */
    @NameInMap("name")
    public String name;

    @NameInMap("option")
    public AddFolderRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>property_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>property_value</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>PRIVATE</p>
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
        @NameInMap("appProperties")
        public java.util.List<AddFolderRequestOptionAppProperties> appProperties;

        /**
         * <strong>example:</strong>
         * <p>AUTO_RENAME</p>
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
