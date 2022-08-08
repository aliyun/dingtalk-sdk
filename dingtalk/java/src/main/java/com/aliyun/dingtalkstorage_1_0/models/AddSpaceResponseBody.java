// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddSpaceResponseBody extends TeaModel {
    // 空间详情
    @NameInMap("space")
    public AddSpaceResponseBodySpace space;

    public static AddSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddSpaceResponseBody self = new AddSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public AddSpaceResponseBody setSpace(AddSpaceResponseBodySpace space) {
        this.space = space;
        return this;
    }
    public AddSpaceResponseBodySpace getSpace() {
        return this.space;
    }

    public static class AddSpaceResponseBodySpaceCapabilities extends TeaModel {
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

        public static AddSpaceResponseBodySpaceCapabilities build(java.util.Map<String, ?> map) throws Exception {
            AddSpaceResponseBodySpaceCapabilities self = new AddSpaceResponseBodySpaceCapabilities();
            return TeaModel.build(map, self);
        }

        public AddSpaceResponseBodySpaceCapabilities setCanRecordRecentFile(Boolean canRecordRecentFile) {
            this.canRecordRecentFile = canRecordRecentFile;
            return this;
        }
        public Boolean getCanRecordRecentFile() {
            return this.canRecordRecentFile;
        }

        public AddSpaceResponseBodySpaceCapabilities setCanRename(Boolean canRename) {
            this.canRename = canRename;
            return this;
        }
        public Boolean getCanRename() {
            return this.canRename;
        }

        public AddSpaceResponseBodySpaceCapabilities setCanSearch(Boolean canSearch) {
            this.canSearch = canSearch;
            return this;
        }
        public Boolean getCanSearch() {
            return this.canSearch;
        }

    }

    public static class AddSpaceResponseBodySpace extends TeaModel {
        // 空间能力项
        @NameInMap("capabilities")
        public AddSpaceResponseBodySpaceCapabilities capabilities;

        // 空间归属企业的id
        @NameInMap("corpId")
        public String corpId;

        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 创建者id
        @NameInMap("creatorId")
        public String creatorId;

        // 空间id
        @NameInMap("id")
        public String id;

        // 修改时间
        @NameInMap("modifiedTime")
        public String modifiedTime;

        // 修改者id
        @NameInMap("modifierId")
        public String modifierId;

        // 空间名称
        @NameInMap("name")
        public String name;

        // 所有者id, 根据ownerType定义, 确定值的所属类型
        @NameInMap("ownerId")
        public String ownerId;

        // owner类型
        // 枚举值:
        // 	USER: 用户类型
        // 	APP: App类型
        @NameInMap("ownerType")
        public String ownerType;

        // 总容量
        @NameInMap("quota")
        public Long quota;

        // 业务场景，可以自定义，表示多个不同空间的聚合，可以提供对特定场景做能力设计、容量管理，如根据场景来做搜索或查询。
        // 创建空间时，不指定scene, 默认值是default
        // 默认值:
        // 	default
        @NameInMap("scene")
        public String scene;

        // 关联业务id, 配合scene一起使用。创建空间时，不指定sceneId， 默认值是0
        // 默认值:
        // 	0
        @NameInMap("sceneId")
        public String sceneId;

        // 空间状态
        // 枚举值:
        // 	NORMAL: 正常
        // 	DELETE: 已删除
        @NameInMap("status")
        public String status;

        // 已使用容量
        @NameInMap("usedQuota")
        public Long usedQuota;

        public static AddSpaceResponseBodySpace build(java.util.Map<String, ?> map) throws Exception {
            AddSpaceResponseBodySpace self = new AddSpaceResponseBodySpace();
            return TeaModel.build(map, self);
        }

        public AddSpaceResponseBodySpace setCapabilities(AddSpaceResponseBodySpaceCapabilities capabilities) {
            this.capabilities = capabilities;
            return this;
        }
        public AddSpaceResponseBodySpaceCapabilities getCapabilities() {
            return this.capabilities;
        }

        public AddSpaceResponseBodySpace setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddSpaceResponseBodySpace setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public AddSpaceResponseBodySpace setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public AddSpaceResponseBodySpace setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public AddSpaceResponseBodySpace setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public AddSpaceResponseBodySpace setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public AddSpaceResponseBodySpace setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddSpaceResponseBodySpace setOwnerId(String ownerId) {
            this.ownerId = ownerId;
            return this;
        }
        public String getOwnerId() {
            return this.ownerId;
        }

        public AddSpaceResponseBodySpace setOwnerType(String ownerType) {
            this.ownerType = ownerType;
            return this;
        }
        public String getOwnerType() {
            return this.ownerType;
        }

        public AddSpaceResponseBodySpace setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public AddSpaceResponseBodySpace setScene(String scene) {
            this.scene = scene;
            return this;
        }
        public String getScene() {
            return this.scene;
        }

        public AddSpaceResponseBodySpace setSceneId(String sceneId) {
            this.sceneId = sceneId;
            return this;
        }
        public String getSceneId() {
            return this.sceneId;
        }

        public AddSpaceResponseBodySpace setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public AddSpaceResponseBodySpace setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
