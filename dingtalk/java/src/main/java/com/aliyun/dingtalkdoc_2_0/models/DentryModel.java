// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DentryModel extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>alidoc</p>
     */
    @NameInMap("contentType")
    public String contentType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1663918630284</p>
     */
    @NameInMap("createdTime")
    public Long createdTime;

    @NameInMap("creator")
    public DentryModelCreator creator;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>YRBd*****KGDA</p>
     */
    @NameInMap("dentryId")
    public String dentryId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>file</p>
     */
    @NameInMap("dentryType")
    public String dentryType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>6or0dp8Z****XWa91xzy3</p>
     */
    @NameInMap("dentryUuid")
    public String dentryUuid;

    /**
     * <strong>example:</strong>
     * <p>v1GXn****KqD4</p>
     */
    @NameInMap("docKey")
    public String docKey;

    /**
     * <strong>example:</strong>
     * <p>adoc</p>
     */
    @NameInMap("extension")
    public String extension;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("hasChildren")
    public Boolean hasChildren;

    @NameInMap("linkSourceInfo")
    public LinkSourceInfo linkSourceInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>钉钉文档</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>测试组织/测试知识库/abc</p>
     */
    @NameInMap("path")
    public String path;

    @NameInMap("space")
    public SpaceModel space;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>YGv0****0xXAr</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    @NameInMap("statisticalInfo")
    public DentryModelStatisticalInfo statisticalInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1663918630284</p>
     */
    @NameInMap("updatedTime")
    public Long updatedTime;

    @NameInMap("updater")
    public DentryModelUpdater updater;

    /**
     * <strong>example:</strong>
     * <p><a href="https://xxx.yy">https://xxx.yy</a></p>
     */
    @NameInMap("url")
    public String url;

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

    public DentryModel setStatisticalInfo(DentryModelStatisticalInfo statisticalInfo) {
        this.statisticalInfo = statisticalInfo;
        return this;
    }
    public DentryModelStatisticalInfo getStatisticalInfo() {
        return this.statisticalInfo;
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>DingTalk</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>YEp3JcM******UIbhwiE</p>
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

    public static class DentryModelStatisticalInfo extends TeaModel {
        @NameInMap("wordCount")
        public Long wordCount;

        public static DentryModelStatisticalInfo build(java.util.Map<String, ?> map) throws Exception {
            DentryModelStatisticalInfo self = new DentryModelStatisticalInfo();
            return TeaModel.build(map, self);
        }

        public DentryModelStatisticalInfo setWordCount(Long wordCount) {
            this.wordCount = wordCount;
            return this;
        }
        public Long getWordCount() {
            return this.wordCount;
        }

    }

    public static class DentryModelUpdater extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>DingTalk</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>YEp3JcM******UIbhwiE</p>
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
        @NameInMap("dentryActions")
        public java.util.List<String> dentryActions;

        /**
         * <strong>example:</strong>
         * <p>5</p>
         */
        @NameInMap("roleCode")
        public String roleCode;

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
