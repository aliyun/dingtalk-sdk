// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DentryModel extends TeaModel {
    // 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包；document-文件。
    @NameInMap("contentType")
    public String contentType;

    // 创建时间。
    @NameInMap("createdTime")
    public Long createdTime;

    // 创建者。
    @NameInMap("creator")
    public DentryModelCreator creator;

    // 节点id。
    @NameInMap("dentryId")
    public String dentryId;

    // 节点类型。file-文件；folder-文件夹。
    @NameInMap("dentryType")
    public String dentryType;

    // 节点全局唯一标识id。
    @NameInMap("dentryUuid")
    public String dentryUuid;

    // 文档docKey，用于标识一篇钉钉文档的key。只有内容类型为alidoc的才会有值。
    @NameInMap("docKey")
    public String docKey;

    // 文件后缀名。
    @NameInMap("extension")
    public String extension;

    // 是否有子节点。
    @NameInMap("hasChildren")
    public Boolean hasChildren;

    // 快捷方式类型的节点，其指向的原始数据信息。
    @NameInMap("linkSourceInfo")
    public LinkSourceInfo linkSourceInfo;

    // 节点名称。
    @NameInMap("name")
    public String name;

    // 节点的路径。
    @NameInMap("path")
    public String path;

    // 知识库信息。
    @NameInMap("space")
    public SpaceModel space;

    // 知识库id。
    @NameInMap("spaceId")
    public String spaceId;

    // 更新时间。
    @NameInMap("updatedTime")
    public Long updatedTime;

    // 更新人。
    @NameInMap("updater")
    public DentryModelUpdater updater;

    // 节点访问url。
    @NameInMap("url")
    public String url;

    // 访问者对当前节点的权限等信息。
    @NameInMap("visitorInfo")
    public DentryModelVisitorInfo visitorInfo;

    public static DentryModel build(java.util.Map<String, ?> map) throws Exception {
        DentryModel self = new DentryModel();
        return TeaModel.build(map, self);
    }

    public DentryModel setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public DentryModel setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public DentryModel setCreator(DentryModelCreator creator) {
        this.creator = creator;
        return this;
    }
    public DentryModelCreator getCreator() {
        return this.creator;
    }

    public DentryModel setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public DentryModel setDentryType(String dentryType) {
        this.dentryType = dentryType;
        return this;
    }
    public String getDentryType() {
        return this.dentryType;
    }

    public DentryModel setDentryUuid(String dentryUuid) {
        this.dentryUuid = dentryUuid;
        return this;
    }
    public String getDentryUuid() {
        return this.dentryUuid;
    }

    public DentryModel setDocKey(String docKey) {
        this.docKey = docKey;
        return this;
    }
    public String getDocKey() {
        return this.docKey;
    }

    public DentryModel setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public DentryModel setHasChildren(Boolean hasChildren) {
        this.hasChildren = hasChildren;
        return this;
    }
    public Boolean getHasChildren() {
        return this.hasChildren;
    }

    public DentryModel setLinkSourceInfo(LinkSourceInfo linkSourceInfo) {
        this.linkSourceInfo = linkSourceInfo;
        return this;
    }
    public LinkSourceInfo getLinkSourceInfo() {
        return this.linkSourceInfo;
    }

    public DentryModel setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DentryModel setPath(String path) {
        this.path = path;
        return this;
    }
    public String getPath() {
        return this.path;
    }

    public DentryModel setSpace(SpaceModel space) {
        this.space = space;
        return this;
    }
    public SpaceModel getSpace() {
        return this.space;
    }

    public DentryModel setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public DentryModel setUpdatedTime(Long updatedTime) {
        this.updatedTime = updatedTime;
        return this;
    }
    public Long getUpdatedTime() {
        return this.updatedTime;
    }

    public DentryModel setUpdater(DentryModelUpdater updater) {
        this.updater = updater;
        return this;
    }
    public DentryModelUpdater getUpdater() {
        return this.updater;
    }

    public DentryModel setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public DentryModel setVisitorInfo(DentryModelVisitorInfo visitorInfo) {
        this.visitorInfo = visitorInfo;
        return this;
    }
    public DentryModelVisitorInfo getVisitorInfo() {
        return this.visitorInfo;
    }

    public static class DentryModelCreator extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static DentryModelCreator build(java.util.Map<String, ?> map) throws Exception {
            DentryModelCreator self = new DentryModelCreator();
            return TeaModel.build(map, self);
        }

        public DentryModelCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DentryModelCreator setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class DentryModelUpdater extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static DentryModelUpdater build(java.util.Map<String, ?> map) throws Exception {
            DentryModelUpdater self = new DentryModelUpdater();
            return TeaModel.build(map, self);
        }

        public DentryModelUpdater setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DentryModelUpdater setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class DentryModelVisitorInfo extends TeaModel {
        // 节点的操作列表。
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        // 空间的操作列表。
        @NameInMap("spaceActions")
        public java.util.List<String> spaceActions;

        public static DentryModelVisitorInfo build(java.util.Map<String, ?> map) throws Exception {
            DentryModelVisitorInfo self = new DentryModelVisitorInfo();
            return TeaModel.build(map, self);
        }

        public DentryModelVisitorInfo setDentryActions(java.util.List<String> dentryActions) {
            this.dentryActions = dentryActions;
            return this;
        }
        public java.util.List<String> getDentryActions() {
            return this.dentryActions;
        }

        public DentryModelVisitorInfo setSpaceActions(java.util.List<String> spaceActions) {
            this.spaceActions = spaceActions;
            return this;
        }
        public java.util.List<String> getSpaceActions() {
            return this.spaceActions;
        }

    }

}
