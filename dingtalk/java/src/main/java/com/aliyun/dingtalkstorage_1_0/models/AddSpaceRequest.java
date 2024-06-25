// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddSpaceRequest extends TeaModel {
    @NameInMap("option")
    public AddSpaceRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
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
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("canRecordRecentFile")
        public Boolean canRecordRecentFile;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("canRename")
        public Boolean canRename;

        /**
         * <strong>example:</strong>
         * <p>true</p>
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
        @NameInMap("capabilities")
        public AddSpaceRequestOptionCapabilities capabilities;

        /**
         * <strong>example:</strong>
         * <p>space_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>USER</p>
         */
        @NameInMap("ownerType")
        public String ownerType;

        @NameInMap("quota")
        public Long quota;

        /**
         * <strong>example:</strong>
         * <p>scene</p>
         */
        @NameInMap("scene")
        public String scene;

        /**
         * <strong>example:</strong>
         * <p>scene_id</p>
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
