// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListStarsRequest extends TeaModel {
    @NameInMap("option")
    public ListStarsRequestOption option;

    @NameInMap("operatorId")
    public String operatorId;

    public static ListStarsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListStarsRequest self = new ListStarsRequest();
        return TeaModel.build(map, self);
    }

    public ListStarsRequest setOption(ListStarsRequestOption option) {
        this.option = option;
        return this;
    }
    public ListStarsRequestOption getOption() {
        return this.option;
    }

    public ListStarsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class ListStarsRequestOption extends TeaModel {
        @NameInMap("contentTypeList")
        public java.util.List<String> contentTypeList;

        @NameInMap("filterDocTypes")
        public java.util.List<String> filterDocTypes;

        @NameInMap("listV2")
        public Boolean listV2;

        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("order")
        public String order;

        @NameInMap("orderBy")
        public String orderBy;

        @NameInMap("withDentryCreatorInfo")
        public Boolean withDentryCreatorInfo;

        @NameInMap("withDentryModifierInfo")
        public Boolean withDentryModifierInfo;

        @NameInMap("withDentryPermissionRole")
        public Boolean withDentryPermissionRole;

        @NameInMap("withSpaceDetail")
        public Boolean withSpaceDetail;

        @NameInMap("withSpacePermissionRole")
        public Boolean withSpacePermissionRole;

        @NameInMap("withTeamDetail")
        public Boolean withTeamDetail;

        public static ListStarsRequestOption build(java.util.Map<String, ?> map) throws Exception {
            ListStarsRequestOption self = new ListStarsRequestOption();
            return TeaModel.build(map, self);
        }

        public ListStarsRequestOption setContentTypeList(java.util.List<String> contentTypeList) {
            this.contentTypeList = contentTypeList;
            return this;
        }
        public java.util.List<String> getContentTypeList() {
            return this.contentTypeList;
        }

        public ListStarsRequestOption setFilterDocTypes(java.util.List<String> filterDocTypes) {
            this.filterDocTypes = filterDocTypes;
            return this;
        }
        public java.util.List<String> getFilterDocTypes() {
            return this.filterDocTypes;
        }

        public ListStarsRequestOption setListV2(Boolean listV2) {
            this.listV2 = listV2;
            return this;
        }
        public Boolean getListV2() {
            return this.listV2;
        }

        public ListStarsRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public ListStarsRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public ListStarsRequestOption setOrder(String order) {
            this.order = order;
            return this;
        }
        public String getOrder() {
            return this.order;
        }

        public ListStarsRequestOption setOrderBy(String orderBy) {
            this.orderBy = orderBy;
            return this;
        }
        public String getOrderBy() {
            return this.orderBy;
        }

        public ListStarsRequestOption setWithDentryCreatorInfo(Boolean withDentryCreatorInfo) {
            this.withDentryCreatorInfo = withDentryCreatorInfo;
            return this;
        }
        public Boolean getWithDentryCreatorInfo() {
            return this.withDentryCreatorInfo;
        }

        public ListStarsRequestOption setWithDentryModifierInfo(Boolean withDentryModifierInfo) {
            this.withDentryModifierInfo = withDentryModifierInfo;
            return this;
        }
        public Boolean getWithDentryModifierInfo() {
            return this.withDentryModifierInfo;
        }

        public ListStarsRequestOption setWithDentryPermissionRole(Boolean withDentryPermissionRole) {
            this.withDentryPermissionRole = withDentryPermissionRole;
            return this;
        }
        public Boolean getWithDentryPermissionRole() {
            return this.withDentryPermissionRole;
        }

        public ListStarsRequestOption setWithSpaceDetail(Boolean withSpaceDetail) {
            this.withSpaceDetail = withSpaceDetail;
            return this;
        }
        public Boolean getWithSpaceDetail() {
            return this.withSpaceDetail;
        }

        public ListStarsRequestOption setWithSpacePermissionRole(Boolean withSpacePermissionRole) {
            this.withSpacePermissionRole = withSpacePermissionRole;
            return this;
        }
        public Boolean getWithSpacePermissionRole() {
            return this.withSpacePermissionRole;
        }

        public ListStarsRequestOption setWithTeamDetail(Boolean withTeamDetail) {
            this.withTeamDetail = withTeamDetail;
            return this;
        }
        public Boolean getWithTeamDetail() {
            return this.withTeamDetail;
        }

    }

}
