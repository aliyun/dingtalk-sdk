// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DentryModel extends TeaModel {
    /**
     * <p>内容类型。alidoc-钉钉文档；link-快捷方式；archive-压缩包；document-文件。</p>
     */
    @NameInMap("contentType")
    public String contentType;

    /**
     * <p>创建时间。</p>
     */
    @NameInMap("createdTime")
    public Long createdTime;

    /**
     * <p>创建者。</p>
     */
    @NameInMap("creator")
    public DentryModelCreator creator;

    /**
     * <p>节点id。</p>
     */
    @NameInMap("dentryId")
    public String dentryId;

    /**
     * <p>节点类型。file-文件；folder-文件夹。</p>
     */
    @NameInMap("dentryType")
    public String dentryType;

    /**
     * <p>节点全局唯一标识id。</p>
     */
    @NameInMap("dentryUuid")
    public String dentryUuid;

    /**
     * <p>文档docKey，用于标识一篇钉钉文档的key。只有内容类型为alidoc的才会有值。</p>
     */
    @NameInMap("docKey")
    public String docKey;

    /**
     * <p>文件后缀名。</p>
     */
    @NameInMap("extension")
    public String extension;

    /**
     * <p>是否有子节点。</p>
     */
    @NameInMap("hasChildren")
    public Boolean hasChildren;

    /**
     * <p>快捷方式类型的节点，其指向的原始数据信息。</p>
     */
    @NameInMap("linkSourceInfo")
    public LinkSourceInfo linkSourceInfo;

    /**
     * <p>节点名称。</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>节点的路径。</p>
     */
    @NameInMap("path")
    public String path;

    /**
     * <p>知识库信息。</p>
     */
    @NameInMap("space")
    public SpaceModel space;

    /**
     * <p>知识库id。</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    /**
     * <p>更新时间。</p>
     */
    @NameInMap("updatedTime")
    public Long updatedTime;

    /**
     * <p>更新人。</p>
     */
    @NameInMap("updater")
    public DentryModelUpdater updater;

    /**
     * <p>节点访问url。</p>
     */
    @NameInMap("url")
    public String url;

    /**
     * <p>访问者对当前节点的权限等信息。</p>
     */
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
        /**
         * <p>用户名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>用户unionId。</p>
         */
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
        /**
         * <p>用户名称。</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>用户unionId。</p>
         */
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
        /**
         * <p>节点的操作列表。</p>
         */
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        /**
         * <p>当前用户对这个空间的访问角色。</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

        /**
         * <p>空间的操作列表。</p>
         */
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

        public DentryModelVisitorInfo setRoleCode(String roleCode) {
            this.roleCode = roleCode;
            return this;
        }
        public String getRoleCode() {
            return this.roleCode;
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
