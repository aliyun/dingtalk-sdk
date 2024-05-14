// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconnector_1_0.models;

import com.aliyun.tea.*;

public class SearchActionsResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<SearchActionsResponseBodyList> list;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("totalCount")
    public Long totalCount;

    public static SearchActionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchActionsResponseBody self = new SearchActionsResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchActionsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public SearchActionsResponseBody setList(java.util.List<SearchActionsResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<SearchActionsResponseBodyList> getList() {
        return this.list;
    }

    public SearchActionsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchActionsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class SearchActionsResponseBodyList extends TeaModel {
        @NameInMap("authorityUrl")
        public String authorityUrl;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("authorized")
        public Boolean authorized;

        @NameInMap("connectAssetUri")
        public String connectAssetUri;

        @NameInMap("connectorId")
        public String connectorId;

        @NameInMap("description")
        public String description;

        @NameInMap("icon")
        public String icon;

        @NameInMap("id")
        public String id;

        @NameInMap("integrationType")
        public String integrationType;

        @NameInMap("name")
        public String name;

        @NameInMap("providerCorpId")
        public String providerCorpId;

        public static SearchActionsResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            SearchActionsResponseBodyList self = new SearchActionsResponseBodyList();
            return TeaModel.build(map, self);
        }

        public SearchActionsResponseBodyList setAuthorityUrl(String authorityUrl) {
            this.authorityUrl = authorityUrl;
            return this;
        }
        public String getAuthorityUrl() {
            return this.authorityUrl;
        }

        public SearchActionsResponseBodyList setAuthorized(Boolean authorized) {
            this.authorized = authorized;
            return this;
        }
        public Boolean getAuthorized() {
            return this.authorized;
        }

        public SearchActionsResponseBodyList setConnectAssetUri(String connectAssetUri) {
            this.connectAssetUri = connectAssetUri;
            return this;
        }
        public String getConnectAssetUri() {
            return this.connectAssetUri;
        }

        public SearchActionsResponseBodyList setConnectorId(String connectorId) {
            this.connectorId = connectorId;
            return this;
        }
        public String getConnectorId() {
            return this.connectorId;
        }

        public SearchActionsResponseBodyList setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public SearchActionsResponseBodyList setIcon(String icon) {
            this.icon = icon;
            return this;
        }
        public String getIcon() {
            return this.icon;
        }

        public SearchActionsResponseBodyList setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SearchActionsResponseBodyList setIntegrationType(String integrationType) {
            this.integrationType = integrationType;
            return this;
        }
        public String getIntegrationType() {
            return this.integrationType;
        }

        public SearchActionsResponseBodyList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SearchActionsResponseBodyList setProviderCorpId(String providerCorpId) {
            this.providerCorpId = providerCorpId;
            return this;
        }
        public String getProviderCorpId() {
            return this.providerCorpId;
        }

    }

}
