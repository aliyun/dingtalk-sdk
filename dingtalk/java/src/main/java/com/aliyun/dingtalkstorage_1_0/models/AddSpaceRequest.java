// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddSpaceRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public AddSpaceRequestOption option;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static AddSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        AddSpaceRequest self = new AddSpaceRequest();
        return TeaModel.build(map, self);
    }

    public AddSpaceRequest setOption(AddSpaceRequestOption option) {
        this.option = option;
        return this;
    }
    public AddSpaceRequestOption getOption() {
        return this.option;
    }

    public AddSpaceRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class AddSpaceRequestOptionCapabilities extends TeaModel {
        /**
         * <p>是否进最近使用, 默认不支持</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("canRecordRecentFile")
        public Boolean canRecordRecentFile;

        /**
         * <p>是否支持重命名空间名称, 默认不支持</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("canRename")
        public Boolean canRename;

        /**
         * <p>是否支持搜索, 默认不支持</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("canSearch")
        public Boolean canSearch;

        public static AddSpaceRequestOptionCapabilities build(java.util.Map<String, ?> map) throws Exception {
            AddSpaceRequestOptionCapabilities self = new AddSpaceRequestOptionCapabilities();
            return TeaModel.build(map, self);
        }

        public AddSpaceRequestOptionCapabilities setCanRecordRecentFile(Boolean canRecordRecentFile) {
            this.canRecordRecentFile = canRecordRecentFile;
            return this;
        }
        public Boolean getCanRecordRecentFile() {
            return this.canRecordRecentFile;
        }

        public AddSpaceRequestOptionCapabilities setCanRename(Boolean canRename) {
            this.canRename = canRename;
            return this;
        }
        public Boolean getCanRename() {
            return this.canRename;
        }

        public AddSpaceRequestOptionCapabilities setCanSearch(Boolean canSearch) {
            this.canSearch = canSearch;
            return this;
        }
        public Boolean getCanSearch() {
            return this.canSearch;
        }

    }

    public static class AddSpaceRequestOption extends TeaModel {
        /**
         * <p>空间能力项, 默认表示不设置拓展能力项</p>
         */
        @NameInMap("capabilities")
        public AddSpaceRequestOptionCapabilities capabilities;

        /**
         * <p>空间名称，默认无空间名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>owner类型, 空间Owner可以是用户或应用</p>
         * <p>如果是应用类型，需要单独授权</p>
         * <p>枚举值:</p>
         * <p>	USER: 用户类型</p>
         * <p>	APP: App类型</p>
         * <p>默认值:</p>
         * <p>	USER</p>
         */
        @NameInMap("ownerType")
        public String ownerType;

        /**
         * <p>空间能使用最大容量, 默认表示无最大容量</p>
         */
        @NameInMap("quota")
        public Long quota;

        /**
         * <p>空间场景，详见 Space.scene 字段. 不指定默认值是default</p>
         * <p>只能由数字和字母组成</p>
         * <p>默认值:</p>
         * <p>	default</p>
         */
        @NameInMap("scene")
        public String scene;

        /**
         * <p>空间场景Id，详见 Space.sceneId 字段. 不指定默认值是0</p>
         * <p>只能由数字和字母组成</p>
         * <p>默认值:</p>
         * <p>	0</p>
         */
        @NameInMap("sceneId")
        public String sceneId;

        public static AddSpaceRequestOption build(java.util.Map<String, ?> map) throws Exception {
            AddSpaceRequestOption self = new AddSpaceRequestOption();
            return TeaModel.build(map, self);
        }

        public AddSpaceRequestOption setCapabilities(AddSpaceRequestOptionCapabilities capabilities) {
            this.capabilities = capabilities;
            return this;
        }
        public AddSpaceRequestOptionCapabilities getCapabilities() {
            return this.capabilities;
        }

        public AddSpaceRequestOption setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddSpaceRequestOption setOwnerType(String ownerType) {
            this.ownerType = ownerType;
            return this;
        }
        public String getOwnerType() {
            return this.ownerType;
        }

        public AddSpaceRequestOption setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public AddSpaceRequestOption setScene(String scene) {
            this.scene = scene;
            return this;
        }
        public String getScene() {
            return this.scene;
        }

        public AddSpaceRequestOption setSceneId(String sceneId) {
            this.sceneId = sceneId;
            return this;
        }
        public String getSceneId() {
            return this.sceneId;
        }

    }

}
