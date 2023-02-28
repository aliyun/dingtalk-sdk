// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListPinSpacesRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public ListPinSpacesRequestOption option;

    /**
     * <p>操作人id</p>
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
         * <p>分页大小</p>
         * <p>默认值:</p>
         * <p>	20</p>
         * <p>最大值:</p>
         * <p>	20</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        /**
         * <p>分页游标</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <p>是否获取知识库创建者信息</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("withSpaceCreatorInfo")
        public Boolean withSpaceCreatorInfo;

        /**
         * <p>是否获取知识库修改者信息</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("withSpaceModifierInfo")
        public Boolean withSpaceModifierInfo;

        /**
         * <p>是否获取知识库权限</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("withSpacePermissionRole")
        public Boolean withSpacePermissionRole;

        /**
         * <p>是否获取小组信息</p>
         * <p>默认值:</p>
         * <p>	false</p>
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
