// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddSpaceRequest extends TeaModel {
    // 可选参数
    @NameInMap("option")
    public AddSpaceRequestOption option;

    // 用户id
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
        // 是否进最近使用, 默认不支持
        // 默认值:
        // 	false
        @NameInMap("canRecordRecentFile")
        public Boolean canRecordRecentFile;

        // 是否支持重命名空间名称, 默认不支持
        // 默认值:
        // 	false
        @NameInMap("canRename")
        public Boolean canRename;

        // 是否支持搜索, 默认不支持
        // 默认值:
        // 	false
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
        // 空间能力项, 默认表示不设置拓展能力项
        @NameInMap("capabilities")
        public AddSpaceRequestOptionCapabilities capabilities;

        // 空间名称，默认无空间名称
        @NameInMap("name")
        public String name;

        // owner类型, 空间Owner可以是用户或应用, 详见 SpaceOwnerTypeEnum
        // 如果是应用类型，需要单独授权
        // 枚举值:
        // 	USER: 用户类型
        // 	APP: App类型
        // 默认值:
        // 	USER
        @NameInMap("ownerType")
        public String ownerType;

        // 空间能使用最大容量, 默认表示无最大容量
        @NameInMap("quota")
        public Long quota;

        // 空间场景，详见 Space.scene 字段. 不指定默认值是default
        // 只能由数字和字母组成
        // 默认值:
        // 	default
        @NameInMap("scene")
        public String scene;

        // 空间场景Id，详见 Space.sceneId 字段. 不指定默认值是0
        // 只能由数字和字母组成
        // 默认值:
        // 	0
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
