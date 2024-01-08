// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ListApplicationResponseBodyData> data;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("totalCount")
    public Long totalCount;

    public static ListApplicationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationResponseBody self = new ListApplicationResponseBody();
        return TeaModel.build(map, self);
    }

    public ListApplicationResponseBody setData(java.util.List<ListApplicationResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ListApplicationResponseBodyData> getData() {
        return this.data;
    }

    public ListApplicationResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public ListApplicationResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ListApplicationResponseBodyData extends TeaModel {
        @NameInMap("appConfig")
        public String appConfig;

        @NameInMap("appType")
        public String appType;

        @NameInMap("applicationStatus")
        public String applicationStatus;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("description")
        public String description;

        @NameInMap("icon")
        public String icon;

        @NameInMap("inexistence")
        public String inexistence;

        @NameInMap("name")
        public String name;

        @NameInMap("subCorpId")
        public String subCorpId;

        @NameInMap("systemToken")
        public String systemToken;

        public static ListApplicationResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ListApplicationResponseBodyData self = new ListApplicationResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ListApplicationResponseBodyData setAppConfig(String appConfig) {
            this.appConfig = appConfig;
            return this;
        }
        public String getAppConfig() {
            return this.appConfig;
        }

        public ListApplicationResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public ListApplicationResponseBodyData setApplicationStatus(String applicationStatus) {
            this.applicationStatus = applicationStatus;
            return this;
        }
        public String getApplicationStatus() {
            return this.applicationStatus;
        }

        public ListApplicationResponseBodyData setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public ListApplicationResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public ListApplicationResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public ListApplicationResponseBodyData setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public ListApplicationResponseBodyData setInexistence(String inexistence) {
            this.inexistence = inexistence;
            return this;
        }
        public String getInexistence() {
            return this.inexistence;
        }

        public ListApplicationResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListApplicationResponseBodyData setSubCorpId(String subCorpId) {
            this.subCorpId = subCorpId;
            return this;
        }
        public String getSubCorpId() {
            return this.subCorpId;
        }

        public ListApplicationResponseBodyData setSystemToken(String systemToken) {
            this.systemToken = systemToken;
            return this;
        }
        public String getSystemToken() {
            return this.systemToken;
        }

    }

}
