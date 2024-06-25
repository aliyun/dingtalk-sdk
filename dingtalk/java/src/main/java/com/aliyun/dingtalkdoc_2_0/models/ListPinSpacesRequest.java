// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListPinSpacesRequest extends TeaModel {
    @NameInMap("option")
    public ListPinSpacesRequestOption option;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
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
        /**
         * <strong>example:</strong>
         * <p>20</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        /**
         * <strong>example:</strong>
         * <p>next_token</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("withSpaceCreatorInfo")
        public Boolean withSpaceCreatorInfo;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("withSpaceModifierInfo")
        public Boolean withSpaceModifierInfo;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("withSpacePermissionRole")
        public Boolean withSpacePermissionRole;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
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
