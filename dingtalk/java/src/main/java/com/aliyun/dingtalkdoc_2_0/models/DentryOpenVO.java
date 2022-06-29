// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DentryOpenVO extends TeaModel {
    // 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包。
    @NameInMap("contentType")
    public String contentType;

    // 创建时间。
    @NameInMap("createdTime")
    public Long createdTime;

    // 创建者。
    @NameInMap("creator")
    public DentryOpenVOCreator creator;

    // 节点id。
    @NameInMap("dentryId")
    public String dentryId;

    // 节点类型。file-文件；folder-文件夹。
    @NameInMap("dentryType")
    public String dentryType;

    // 节点全局唯一标识id。
    @NameInMap("dentryUuid")
    public String dentryUuid;

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
    public SpaceOpenVO space;

    // 知识库id。
    @NameInMap("spaceId")
    public String spaceId;

    // 更新时间。
    @NameInMap("updatedTime")
    public Long updatedTime;

    // 更新人。
    @NameInMap("updater")
    public DentryOpenVOUpdater updater;

    // 节点访问url。
    @NameInMap("url")
    public String url;

    // 访问者对当前节点的权限等信息。
    @NameInMap("visitorInfo")
    public DentryOpenVOVisitorInfo visitorInfo;

    public static DentryOpenVO build(java.util.Map<String, ?> map) throws Exception {
        DentryOpenVO self = new DentryOpenVO();
        return TeaModel.build(map, self);
    }

    public DentryOpenVO setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public DentryOpenVO setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public DentryOpenVO setCreator(DentryOpenVOCreator creator) {
        this.creator = creator;
        return this;
    }
    public DentryOpenVOCreator getCreator() {
        return this.creator;
    }

    public DentryOpenVO setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public DentryOpenVO setDentryType(String dentryType) {
        this.dentryType = dentryType;
        return this;
    }
    public String getDentryType() {
        return this.dentryType;
    }

    public DentryOpenVO setDentryUuid(String dentryUuid) {
        this.dentryUuid = dentryUuid;
        return this;
    }
    public String getDentryUuid() {
        return this.dentryUuid;
    }

    public DentryOpenVO setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public DentryOpenVO setHasChildren(Boolean hasChildren) {
        this.hasChildren = hasChildren;
        return this;
    }
    public Boolean getHasChildren() {
        return this.hasChildren;
    }

    public DentryOpenVO setLinkSourceInfo(LinkSourceInfo linkSourceInfo) {
        this.linkSourceInfo = linkSourceInfo;
        return this;
    }
    public LinkSourceInfo getLinkSourceInfo() {
        return this.linkSourceInfo;
    }

    public DentryOpenVO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DentryOpenVO setPath(String path) {
        this.path = path;
        return this;
    }
    public String getPath() {
        return this.path;
    }

    public DentryOpenVO setSpace(SpaceOpenVO space) {
        this.space = space;
        return this;
    }
    public SpaceOpenVO getSpace() {
        return this.space;
    }

    public DentryOpenVO setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public DentryOpenVO setUpdatedTime(Long updatedTime) {
        this.updatedTime = updatedTime;
        return this;
    }
    public Long getUpdatedTime() {
        return this.updatedTime;
    }

    public DentryOpenVO setUpdater(DentryOpenVOUpdater updater) {
        this.updater = updater;
        return this;
    }
    public DentryOpenVOUpdater getUpdater() {
        return this.updater;
    }

    public DentryOpenVO setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public DentryOpenVO setVisitorInfo(DentryOpenVOVisitorInfo visitorInfo) {
        this.visitorInfo = visitorInfo;
        return this;
    }
    public DentryOpenVOVisitorInfo getVisitorInfo() {
        return this.visitorInfo;
    }

    public static class DentryOpenVOCreator extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static DentryOpenVOCreator build(java.util.Map<String, ?> map) throws Exception {
            DentryOpenVOCreator self = new DentryOpenVOCreator();
            return TeaModel.build(map, self);
        }

        public DentryOpenVOCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DentryOpenVOCreator setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class DentryOpenVOUpdater extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static DentryOpenVOUpdater build(java.util.Map<String, ?> map) throws Exception {
            DentryOpenVOUpdater self = new DentryOpenVOUpdater();
            return TeaModel.build(map, self);
        }

        public DentryOpenVOUpdater setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DentryOpenVOUpdater setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class DentryOpenVOVisitorInfo extends TeaModel {
        // 节点的操作列表。
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        // 空间的操作列表。
        @NameInMap("spaceActions")
        public java.util.List<String> spaceActions;

        public static DentryOpenVOVisitorInfo build(java.util.Map<String, ?> map) throws Exception {
            DentryOpenVOVisitorInfo self = new DentryOpenVOVisitorInfo();
            return TeaModel.build(map, self);
        }

        public DentryOpenVOVisitorInfo setDentryActions(java.util.List<String> dentryActions) {
            this.dentryActions = dentryActions;
            return this;
        }
        public java.util.List<String> getDentryActions() {
            return this.dentryActions;
        }

        public DentryOpenVOVisitorInfo setSpaceActions(java.util.List<String> spaceActions) {
            this.spaceActions = spaceActions;
            return this;
        }
        public java.util.List<String> getSpaceActions() {
            return this.spaceActions;
        }

    }

}
