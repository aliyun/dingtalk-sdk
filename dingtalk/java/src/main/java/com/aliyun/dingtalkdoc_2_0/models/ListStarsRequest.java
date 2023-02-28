// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListStarsRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public ListStarsRequestOption option;

    /**
     * <p>操作人id</p>
     */
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
        /**
         * <p>文档类型</p>
         * <p>最大size:</p>
         * <p>	20</p>
         */
        @NameInMap("filterDocTypes")
        public java.util.List<String> filterDocTypes;

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
         * <p>排序规则, 升降或降序</p>
         * <p>支持按字段排序，支持字段在orderBy中</p>
         * <p>枚举值:</p>
         * <p>	ASC: 升序</p>
         * <p>	DESC: 降序</p>
         * <p>默认值:</p>
         * <p>	ASC</p>
         */
        @NameInMap("order")
        public String order;

        /**
         * <p>排序字段, 根据选择字段排序</p>
         * <p>枚举值:</p>
         * <p>	UPDATE_TIME: updateTime</p>
         * <p>	NAME: name</p>
         * <p>	CREATE_TIME: createTime</p>
         */
        @NameInMap("orderBy")
        public String orderBy;

        /**
         * <p>是否获取文档创建者名称</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("withDentryCreatorInfo")
        public Boolean withDentryCreatorInfo;

        /**
         * <p>是否获取文档修改者名称</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("withDentryModifierInfo")
        public Boolean withDentryModifierInfo;

        /**
         * <p>是否获取文档权限</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("withDentryPermissionRole")
        public Boolean withDentryPermissionRole;

        /**
         * <p>是否获取知识库信息</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("withSpaceDetail")
        public Boolean withSpaceDetail;

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

        public static ListStarsRequestOption build(java.util.Map<String, ?> map) throws Exception {
            ListStarsRequestOption self = new ListStarsRequestOption();
            return TeaModel.build(map, self);
        }

        public ListStarsRequestOption setFilterDocTypes(java.util.List<String> filterDocTypes) {
            this.filterDocTypes = filterDocTypes;
            return this;
        }
        public java.util.List<String> getFilterDocTypes() {
            return this.filterDocTypes;
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
