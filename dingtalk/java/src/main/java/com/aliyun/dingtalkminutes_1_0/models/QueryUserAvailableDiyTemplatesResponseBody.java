// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryUserAvailableDiyTemplatesResponseBody extends TeaModel {
    @NameInMap("hasNext")
    public Boolean hasNext;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("orgDiyTemplates")
    public java.util.List<QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates> orgDiyTemplates;

    @NameInMap("userDiyTemplates")
    public java.util.List<QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates> userDiyTemplates;

    public static QueryUserAvailableDiyTemplatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserAvailableDiyTemplatesResponseBody self = new QueryUserAvailableDiyTemplatesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserAvailableDiyTemplatesResponseBody setHasNext(Boolean hasNext) {
        this.hasNext = hasNext;
        return this;
    }
    public Boolean getHasNext() {
        return this.hasNext;
    }

    public QueryUserAvailableDiyTemplatesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryUserAvailableDiyTemplatesResponseBody setOrgDiyTemplates(java.util.List<QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates> orgDiyTemplates) {
        this.orgDiyTemplates = orgDiyTemplates;
        return this;
    }
    public java.util.List<QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates> getOrgDiyTemplates() {
        return this.orgDiyTemplates;
    }

    public QueryUserAvailableDiyTemplatesResponseBody setUserDiyTemplates(java.util.List<QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates> userDiyTemplates) {
        this.userDiyTemplates = userDiyTemplates;
        return this;
    }
    public java.util.List<QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates> getUserDiyTemplates() {
        return this.userDiyTemplates;
    }

    public static class QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates extends TeaModel {
        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("diyTemplateBriefIntro")
        public String diyTemplateBriefIntro;

        @NameInMap("diyTemplateIconUrl")
        public String diyTemplateIconUrl;

        @NameInMap("diyTemplateKey")
        public String diyTemplateKey;

        @NameInMap("diyTemplateLatestVersion")
        public Long diyTemplateLatestVersion;

        @NameInMap("diyTemplateSource")
        public String diyTemplateSource;

        @NameInMap("diyTemplateTitle")
        public String diyTemplateTitle;

        @NameInMap("modifiedTime")
        public Long modifiedTime;

        public static QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates build(java.util.Map<String, ?> map) throws Exception {
            QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates self = new QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates();
            return TeaModel.build(map, self);
        }

        public QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates setDiyTemplateBriefIntro(String diyTemplateBriefIntro) {
            this.diyTemplateBriefIntro = diyTemplateBriefIntro;
            return this;
        }
        public String getDiyTemplateBriefIntro() {
            return this.diyTemplateBriefIntro;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates setDiyTemplateIconUrl(String diyTemplateIconUrl) {
            this.diyTemplateIconUrl = diyTemplateIconUrl;
            return this;
        }
        public String getDiyTemplateIconUrl() {
            return this.diyTemplateIconUrl;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates setDiyTemplateKey(String diyTemplateKey) {
            this.diyTemplateKey = diyTemplateKey;
            return this;
        }
        public String getDiyTemplateKey() {
            return this.diyTemplateKey;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates setDiyTemplateLatestVersion(Long diyTemplateLatestVersion) {
            this.diyTemplateLatestVersion = diyTemplateLatestVersion;
            return this;
        }
        public Long getDiyTemplateLatestVersion() {
            return this.diyTemplateLatestVersion;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates setDiyTemplateSource(String diyTemplateSource) {
            this.diyTemplateSource = diyTemplateSource;
            return this;
        }
        public String getDiyTemplateSource() {
            return this.diyTemplateSource;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates setDiyTemplateTitle(String diyTemplateTitle) {
            this.diyTemplateTitle = diyTemplateTitle;
            return this;
        }
        public String getDiyTemplateTitle() {
            return this.diyTemplateTitle;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyOrgDiyTemplates setModifiedTime(Long modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public Long getModifiedTime() {
            return this.modifiedTime;
        }

    }

    public static class QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates extends TeaModel {
        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("diyTemplateBriefIntro")
        public String diyTemplateBriefIntro;

        @NameInMap("diyTemplateIconUrl")
        public String diyTemplateIconUrl;

        @NameInMap("diyTemplateKey")
        public String diyTemplateKey;

        @NameInMap("diyTemplateLatestVersion")
        public Long diyTemplateLatestVersion;

        @NameInMap("diyTemplateSource")
        public String diyTemplateSource;

        @NameInMap("diyTemplateTitle")
        public String diyTemplateTitle;

        @NameInMap("modifiedTime")
        public Long modifiedTime;

        public static QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates build(java.util.Map<String, ?> map) throws Exception {
            QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates self = new QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates();
            return TeaModel.build(map, self);
        }

        public QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates setDiyTemplateBriefIntro(String diyTemplateBriefIntro) {
            this.diyTemplateBriefIntro = diyTemplateBriefIntro;
            return this;
        }
        public String getDiyTemplateBriefIntro() {
            return this.diyTemplateBriefIntro;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates setDiyTemplateIconUrl(String diyTemplateIconUrl) {
            this.diyTemplateIconUrl = diyTemplateIconUrl;
            return this;
        }
        public String getDiyTemplateIconUrl() {
            return this.diyTemplateIconUrl;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates setDiyTemplateKey(String diyTemplateKey) {
            this.diyTemplateKey = diyTemplateKey;
            return this;
        }
        public String getDiyTemplateKey() {
            return this.diyTemplateKey;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates setDiyTemplateLatestVersion(Long diyTemplateLatestVersion) {
            this.diyTemplateLatestVersion = diyTemplateLatestVersion;
            return this;
        }
        public Long getDiyTemplateLatestVersion() {
            return this.diyTemplateLatestVersion;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates setDiyTemplateSource(String diyTemplateSource) {
            this.diyTemplateSource = diyTemplateSource;
            return this;
        }
        public String getDiyTemplateSource() {
            return this.diyTemplateSource;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates setDiyTemplateTitle(String diyTemplateTitle) {
            this.diyTemplateTitle = diyTemplateTitle;
            return this;
        }
        public String getDiyTemplateTitle() {
            return this.diyTemplateTitle;
        }

        public QueryUserAvailableDiyTemplatesResponseBodyUserDiyTemplates setModifiedTime(Long modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public Long getModifiedTime() {
            return this.modifiedTime;
        }

    }

}
