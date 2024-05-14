// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListPinSpacesRequest extends TeaModel {
    @NameInMap("option")
    public ListPinSpacesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    public static ListPinSpacesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListPinSpacesRequest self = new ListPinSpacesRequest();
        return TeaModel.build(map, self);
    }

    public ListPinSpacesRequest setOption(ListPinSpacesRequestOption option) {
        this.option = option;
        return this;
    }
    public ListPinSpacesRequestOption getOption() {
        return this.option;
    }

    public ListPinSpacesRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public static class ListPinSpacesRequestOption extends TeaModel {
        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("withSpaceCreatorInfo")
        public Boolean withSpaceCreatorInfo;

        @NameInMap("withSpaceModifierInfo")
        public Boolean withSpaceModifierInfo;

        @NameInMap("withSpacePermissionRole")
        public Boolean withSpacePermissionRole;

        @NameInMap("withTeamDetail")
        public Boolean withTeamDetail;

        public static ListPinSpacesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            ListPinSpacesRequestOption self = new ListPinSpacesRequestOption();
            return TeaModel.build(map, self);
        }

        public ListPinSpacesRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public ListPinSpacesRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public ListPinSpacesRequestOption setWithSpaceCreatorInfo(Boolean withSpaceCreatorInfo) {
            this.withSpaceCreatorInfo = withSpaceCreatorInfo;
            return this;
        }
        public Boolean getWithSpaceCreatorInfo() {
            return this.withSpaceCreatorInfo;
        }

        public ListPinSpacesRequestOption setWithSpaceModifierInfo(Boolean withSpaceModifierInfo) {
            this.withSpaceModifierInfo = withSpaceModifierInfo;
            return this;
        }
        public Boolean getWithSpaceModifierInfo() {
            return this.withSpaceModifierInfo;
        }

        public ListPinSpacesRequestOption setWithSpacePermissionRole(Boolean withSpacePermissionRole) {
            this.withSpacePermissionRole = withSpacePermissionRole;
            return this;
        }
        public Boolean getWithSpacePermissionRole() {
            return this.withSpacePermissionRole;
        }

        public ListPinSpacesRequestOption setWithTeamDetail(Boolean withTeamDetail) {
            this.withTeamDetail = withTeamDetail;
            return this;
        }
        public Boolean getWithTeamDetail() {
            return this.withTeamDetail;
        }

    }

}
