// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnfurlingRegisterInfoResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryUnfurlingRegisterInfoResponseBodyList> list;

    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("success")
    public Boolean success;

    public static QueryUnfurlingRegisterInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUnfurlingRegisterInfoResponseBody self = new QueryUnfurlingRegisterInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUnfurlingRegisterInfoResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryUnfurlingRegisterInfoResponseBody setList(java.util.List<QueryUnfurlingRegisterInfoResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryUnfurlingRegisterInfoResponseBodyList> getList() {
        return this.list;
    }

    public QueryUnfurlingRegisterInfoResponseBody setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public QueryUnfurlingRegisterInfoResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryUnfurlingRegisterInfoResponseBodyList extends TeaModel {
        @NameInMap("apiSecret")
        public String apiSecret;

        @NameInMap("appId")
        public String appId;

        @NameInMap("appName")
        public String appName;

        @NameInMap("callbackType")
        public Integer callbackType;

        @NameInMap("callbackUrl")
        public String callbackUrl;

        @NameInMap("cardTemplateId")
        public String cardTemplateId;

        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("domain")
        public String domain;

        @NameInMap("grayGroupIdList")
        public java.util.List<String> grayGroupIdList;

        @NameInMap("grayUserIdList")
        public java.util.List<String> grayUserIdList;

        @NameInMap("hsfMethodName")
        public String hsfMethodName;

        @NameInMap("hsfServiceName")
        public String hsfServiceName;

        @NameInMap("hsfVersion")
        public String hsfVersion;

        @NameInMap("id")
        public Long id;

        @NameInMap("path")
        public String path;

        @NameInMap("ruleDesc")
        public String ruleDesc;

        @NameInMap("ruleMatchType")
        public Integer ruleMatchType;

        @NameInMap("status")
        public Integer status;

        public static QueryUnfurlingRegisterInfoResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryUnfurlingRegisterInfoResponseBodyList self = new QueryUnfurlingRegisterInfoResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setApiSecret(String apiSecret) {
            this.apiSecret = apiSecret;
            return this;
        }
        public String getApiSecret() {
            return this.apiSecret;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setAppName(String appName) {
            this.appName = appName;
            return this;
        }
        public String getAppName() {
            return this.appName;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setCallbackType(Integer callbackType) {
            this.callbackType = callbackType;
            return this;
        }
        public Integer getCallbackType() {
            return this.callbackType;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setCallbackUrl(String callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
        public String getCallbackUrl() {
            return this.callbackUrl;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setCardTemplateId(String cardTemplateId) {
            this.cardTemplateId = cardTemplateId;
            return this;
        }
        public String getCardTemplateId() {
            return this.cardTemplateId;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setDomain(String domain) {
            this.domain = domain;
            return this;
        }
        public String getDomain() {
            return this.domain;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setGrayGroupIdList(java.util.List<String> grayGroupIdList) {
            this.grayGroupIdList = grayGroupIdList;
            return this;
        }
        public java.util.List<String> getGrayGroupIdList() {
            return this.grayGroupIdList;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setGrayUserIdList(java.util.List<String> grayUserIdList) {
            this.grayUserIdList = grayUserIdList;
            return this;
        }
        public java.util.List<String> getGrayUserIdList() {
            return this.grayUserIdList;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setHsfMethodName(String hsfMethodName) {
            this.hsfMethodName = hsfMethodName;
            return this;
        }
        public String getHsfMethodName() {
            return this.hsfMethodName;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setHsfServiceName(String hsfServiceName) {
            this.hsfServiceName = hsfServiceName;
            return this;
        }
        public String getHsfServiceName() {
            return this.hsfServiceName;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setHsfVersion(String hsfVersion) {
            this.hsfVersion = hsfVersion;
            return this;
        }
        public String getHsfVersion() {
            return this.hsfVersion;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setRuleDesc(String ruleDesc) {
            this.ruleDesc = ruleDesc;
            return this;
        }
        public String getRuleDesc() {
            return this.ruleDesc;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setRuleMatchType(Integer ruleMatchType) {
            this.ruleMatchType = ruleMatchType;
            return this;
        }
        public Integer getRuleMatchType() {
            return this.ruleMatchType;
        }

        public QueryUnfurlingRegisterInfoResponseBodyList setStatus(Integer status) {
            this.status = status;
            return this;
        }
        public Integer getStatus() {
            return this.status;
        }

    }

}
