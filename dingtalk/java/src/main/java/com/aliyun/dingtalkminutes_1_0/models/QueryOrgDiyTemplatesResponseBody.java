// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryOrgDiyTemplatesResponseBody extends TeaModel {
    @NameInMap("diyTemplates")
    public java.util.List<QueryOrgDiyTemplatesResponseBodyDiyTemplates> diyTemplates;

    @NameInMap("hasNext")
    public Boolean hasNext;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("total")
    public Long total;

    public static QueryOrgDiyTemplatesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryOrgDiyTemplatesResponseBody self = new QueryOrgDiyTemplatesResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryOrgDiyTemplatesResponseBody setDiyTemplates(java.util.List<QueryOrgDiyTemplatesResponseBodyDiyTemplates> diyTemplates) {
        this.diyTemplates = diyTemplates;
        return this;
    }
    public java.util.List<QueryOrgDiyTemplatesResponseBodyDiyTemplates> getDiyTemplates() {
        return this.diyTemplates;
    }

    public QueryOrgDiyTemplatesResponseBody setHasNext(Boolean hasNext) {
        this.hasNext = hasNext;
        return this;
    }
    public Boolean getHasNext() {
        return this.hasNext;
    }

    public QueryOrgDiyTemplatesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public QueryOrgDiyTemplatesResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class QueryOrgDiyTemplatesResponseBodyDiyTemplates extends TeaModel {
        @NameInMap("acceptTimes")
        public Long acceptTimes;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("creatorNick")
        public String creatorNick;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

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

        @NameInMap("status")
        public String status;

        public static QueryOrgDiyTemplatesResponseBodyDiyTemplates build(java.util.Map<String, ?> map) throws Exception {
            QueryOrgDiyTemplatesResponseBodyDiyTemplates self = new QueryOrgDiyTemplatesResponseBodyDiyTemplates();
            return TeaModel.build(map, self);
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setAcceptTimes(Long acceptTimes) {
            this.acceptTimes = acceptTimes;
            return this;
        }
        public Long getAcceptTimes() {
            return this.acceptTimes;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setCreatorNick(String creatorNick) {
            this.creatorNick = creatorNick;
            return this;
        }
        public String getCreatorNick() {
            return this.creatorNick;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setDiyTemplateBriefIntro(String diyTemplateBriefIntro) {
            this.diyTemplateBriefIntro = diyTemplateBriefIntro;
            return this;
        }
        public String getDiyTemplateBriefIntro() {
            return this.diyTemplateBriefIntro;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setDiyTemplateIconUrl(String diyTemplateIconUrl) {
            this.diyTemplateIconUrl = diyTemplateIconUrl;
            return this;
        }
        public String getDiyTemplateIconUrl() {
            return this.diyTemplateIconUrl;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setDiyTemplateKey(String diyTemplateKey) {
            this.diyTemplateKey = diyTemplateKey;
            return this;
        }
        public String getDiyTemplateKey() {
            return this.diyTemplateKey;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setDiyTemplateLatestVersion(Long diyTemplateLatestVersion) {
            this.diyTemplateLatestVersion = diyTemplateLatestVersion;
            return this;
        }
        public Long getDiyTemplateLatestVersion() {
            return this.diyTemplateLatestVersion;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setDiyTemplateSource(String diyTemplateSource) {
            this.diyTemplateSource = diyTemplateSource;
            return this;
        }
        public String getDiyTemplateSource() {
            return this.diyTemplateSource;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setDiyTemplateTitle(String diyTemplateTitle) {
            this.diyTemplateTitle = diyTemplateTitle;
            return this;
        }
        public String getDiyTemplateTitle() {
            return this.diyTemplateTitle;
        }

        public QueryOrgDiyTemplatesResponseBodyDiyTemplates setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
