// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DentryOpenVOResult extends TeaModel {
    // 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包。
    @NameInMap("contentType")
    public String contentType;

    // 创建时间。
    @NameInMap("createdTime")
    public Long createdTime;

    // 创建者。
    @NameInMap("creator")
    public DentryOpenVOResultCreator creator;

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
    public DentryOpenVOResultUpdater updater;

    // 节点访问url。
    @NameInMap("url")
    public String url;

    // 访问者对当前节点的权限等信息。
    @NameInMap("visitorInfo")
    public DentryOpenVOResultVisitorInfo visitorInfo;

    public static DentryOpenVOResult build(java.util.Map<String, ?> map) throws Exception {
        DentryOpenVOResult self = new DentryOpenVOResult();
        return TeaModel.build(map, self);
    }

    public DentryOpenVOResult setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public DentryOpenVOResult setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public DentryOpenVOResult setCreator(DentryOpenVOResultCreator creator) {
        this.creator = creator;
        return this;
    }
    public DentryOpenVOResultCreator getCreator() {
        return this.creator;
    }

    public DentryOpenVOResult setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public DentryOpenVOResult setDentryType(String dentryType) {
        this.dentryType = dentryType;
        return this;
    }
    public String getDentryType() {
        return this.dentryType;
    }

    public DentryOpenVOResult setDentryUuid(String dentryUuid) {
        this.dentryUuid = dentryUuid;
        return this;
    }
    public String getDentryUuid() {
        return this.dentryUuid;
    }

    public DentryOpenVOResult setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public DentryOpenVOResult setHasChildren(Boolean hasChildren) {
        this.hasChildren = hasChildren;
        return this;
    }
    public Boolean getHasChildren() {
        return this.hasChildren;
    }

    public DentryOpenVOResult setLinkSourceInfo(LinkSourceInfo linkSourceInfo) {
        this.linkSourceInfo = linkSourceInfo;
        return this;
    }
    public LinkSourceInfo getLinkSourceInfo() {
        return this.linkSourceInfo;
    }

    public DentryOpenVOResult setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DentryOpenVOResult setPath(String path) {
        this.path = path;
        return this;
    }
    public String getPath() {
        return this.path;
    }

    public DentryOpenVOResult setSpace(SpaceOpenVO space) {
        this.space = space;
        return this;
    }
    public SpaceOpenVO getSpace() {
        return this.space;
    }

    public DentryOpenVOResult setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public DentryOpenVOResult setUpdatedTime(Long updatedTime) {
        this.updatedTime = updatedTime;
        return this;
    }
    public Long getUpdatedTime() {
        return this.updatedTime;
    }

    public DentryOpenVOResult setUpdater(DentryOpenVOResultUpdater updater) {
        this.updater = updater;
        return this;
    }
    public DentryOpenVOResultUpdater getUpdater() {
        return this.updater;
    }

    public DentryOpenVOResult setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public DentryOpenVOResult setVisitorInfo(DentryOpenVOResultVisitorInfo visitorInfo) {
        this.visitorInfo = visitorInfo;
        return this;
    }
    public DentryOpenVOResultVisitorInfo getVisitorInfo() {
        return this.visitorInfo;
    }

    public static class DentryOpenVOResultCreator extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static DentryOpenVOResultCreator build(java.util.Map<String, ?> map) throws Exception {
            DentryOpenVOResultCreator self = new DentryOpenVOResultCreator();
            return TeaModel.build(map, self);
        }

        public DentryOpenVOResultCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DentryOpenVOResultCreator setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class DentryOpenVOResultUpdater extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static DentryOpenVOResultUpdater build(java.util.Map<String, ?> map) throws Exception {
            DentryOpenVOResultUpdater self = new DentryOpenVOResultUpdater();
            return TeaModel.build(map, self);
        }

        public DentryOpenVOResultUpdater setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DentryOpenVOResultUpdater setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class DentryOpenVOResultVisitorInfo extends TeaModel {
        // 节点的操作列表。
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        // 空间的操作列表。
        @NameInMap("spaceActions")
        public java.util.List<String> spaceActions;

        public static DentryOpenVOResultVisitorInfo build(java.util.Map<String, ?> map) throws Exception {
            DentryOpenVOResultVisitorInfo self = new DentryOpenVOResultVisitorInfo();
            return TeaModel.build(map, self);
        }

        public DentryOpenVOResultVisitorInfo setDentryActions(java.util.List<String> dentryActions) {
            this.dentryActions = dentryActions;
            return this;
        }
        public java.util.List<String> getDentryActions() {
            return this.dentryActions;
        }

        public DentryOpenVOResultVisitorInfo setSpaceActions(java.util.List<String> spaceActions) {
            this.spaceActions = spaceActions;
            return this;
        }
        public java.util.List<String> getSpaceActions() {
            return this.spaceActions;
        }

    }

}
