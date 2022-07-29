// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DentryVO extends TeaModel {
    // 内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包；document-文件。
    @NameInMap("contentType")
    public String contentType;

    // 创建时间。
    @NameInMap("createdTime")
    public Long createdTime;

    // 创建者。
    @NameInMap("creator")
    public DentryVOCreator creator;

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
    public DentryVOUpdater updater;

    // 节点访问url。
    @NameInMap("url")
    public String url;

    // 访问者对当前节点的权限等信息。
    @NameInMap("visitorInfo")
    public DentryVOVisitorInfo visitorInfo;

    public static DentryVO build(java.util.Map<String, ?> map) throws Exception {
        DentryVO self = new DentryVO();
        return TeaModel.build(map, self);
    }

    public DentryVO setContentType(String contentType) {
        this.contentType = contentType;
        return this;
    }
    public String getContentType() {
        return this.contentType;
    }

    public DentryVO setCreatedTime(Long createdTime) {
        this.createdTime = createdTime;
        return this;
    }
    public Long getCreatedTime() {
        return this.createdTime;
    }

    public DentryVO setCreator(DentryVOCreator creator) {
        this.creator = creator;
        return this;
    }
    public DentryVOCreator getCreator() {
        return this.creator;
    }

    public DentryVO setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public DentryVO setDentryType(String dentryType) {
        this.dentryType = dentryType;
        return this;
    }
    public String getDentryType() {
        return this.dentryType;
    }

    public DentryVO setDentryUuid(String dentryUuid) {
        this.dentryUuid = dentryUuid;
        return this;
    }
    public String getDentryUuid() {
        return this.dentryUuid;
    }

    public DentryVO setDocKey(String docKey) {
        this.docKey = docKey;
        return this;
    }
    public String getDocKey() {
        return this.docKey;
    }

    public DentryVO setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public DentryVO setHasChildren(Boolean hasChildren) {
        this.hasChildren = hasChildren;
        return this;
    }
    public Boolean getHasChildren() {
        return this.hasChildren;
    }

    public DentryVO setLinkSourceInfo(LinkSourceInfo linkSourceInfo) {
        this.linkSourceInfo = linkSourceInfo;
        return this;
    }
    public LinkSourceInfo getLinkSourceInfo() {
        return this.linkSourceInfo;
    }

    public DentryVO setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public DentryVO setPath(String path) {
        this.path = path;
        return this;
    }
    public String getPath() {
        return this.path;
    }

    public DentryVO setSpace(SpaceModel space) {
        this.space = space;
        return this;
    }
    public SpaceModel getSpace() {
        return this.space;
    }

    public DentryVO setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public DentryVO setUpdatedTime(Long updatedTime) {
        this.updatedTime = updatedTime;
        return this;
    }
    public Long getUpdatedTime() {
        return this.updatedTime;
    }

    public DentryVO setUpdater(DentryVOUpdater updater) {
        this.updater = updater;
        return this;
    }
    public DentryVOUpdater getUpdater() {
        return this.updater;
    }

    public DentryVO setUrl(String url) {
        this.url = url;
        return this;
    }
    public String getUrl() {
        return this.url;
    }

    public DentryVO setVisitorInfo(DentryVOVisitorInfo visitorInfo) {
        this.visitorInfo = visitorInfo;
        return this;
    }
    public DentryVOVisitorInfo getVisitorInfo() {
        return this.visitorInfo;
    }

    public static class DentryVOCreator extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static DentryVOCreator build(java.util.Map<String, ?> map) throws Exception {
            DentryVOCreator self = new DentryVOCreator();
            return TeaModel.build(map, self);
        }

        public DentryVOCreator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DentryVOCreator setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class DentryVOUpdater extends TeaModel {
        // 用户名称。
        @NameInMap("name")
        public String name;

        // 用户unionId。
        @NameInMap("unionId")
        public String unionId;

        public static DentryVOUpdater build(java.util.Map<String, ?> map) throws Exception {
            DentryVOUpdater self = new DentryVOUpdater();
            return TeaModel.build(map, self);
        }

        public DentryVOUpdater setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public DentryVOUpdater setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class DentryVOVisitorInfo extends TeaModel {
        // 节点的操作列表。
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        // 当前用户对这个空间的访问角色。
        @NameInMap("roleCode")
        public String roleCode;

        // 空间的操作列表。
        @NameInMap("spaceActions")
        public java.util.List<String> spaceActions;

        public static DentryVOVisitorInfo build(java.util.Map<String, ?> map) throws Exception {
            DentryVOVisitorInfo self = new DentryVOVisitorInfo();
            return TeaModel.build(map, self);
        }

        public DentryVOVisitorInfo setDentryActions(java.util.List<String> dentryActions) {
            this.dentryActions = dentryActions;
            return this;
        }
        public java.util.List<String> getDentryActions() {
            return this.dentryActions;
        }

        public DentryVOVisitorInfo setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
        }

        public DentryVOVisitorInfo setSpaceActions(java.util.List<String> spaceActions) {
            this.spaceActions = spaceActions;
            return this;
        }
        public java.util.List<String> getSpaceActions() {
            return this.spaceActions;
        }

    }

}
