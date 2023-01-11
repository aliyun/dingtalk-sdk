// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPermissionByUserIdResponseBody extends TeaModel {
    /**
     * <p>权限信息列表</p>
     */
    @NameInMap("permissionDTOList")
    public java.util.List<QueryPermissionByUserIdResponseBodyPermissionDTOList> permissionDTOList;

    /**
     * <p>用户ID</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryPermissionByUserIdResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPermissionByUserIdResponseBody self = new QueryPermissionByUserIdResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPermissionByUserIdResponseBody setPermissionDTOList(java.util.List<QueryPermissionByUserIdResponseBodyPermissionDTOList> permissionDTOList) {
        this.permissionDTOList = permissionDTOList;
        return this;
    }
    public java.util.List<QueryPermissionByUserIdResponseBodyPermissionDTOList> getPermissionDTOList() {
        return this.permissionDTOList;
    }

    public QueryPermissionByUserIdResponseBody setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class QueryPermissionByUserIdResponseBodyPermissionDTOList extends TeaModel {
        @NameInMap("actionIdList")
        public java.util.List<String> actionIdList;

        @NameInMap("resourceIdentity")
        public String resourceIdentity;

        public static QueryPermissionByUserIdResponseBodyPermissionDTOList build(java.util.Map<String, ?> map) throws Exception {
            QueryPermissionByUserIdResponseBodyPermissionDTOList self = new QueryPermissionByUserIdResponseBodyPermissionDTOList();
            return TeaModel.build(map, self);
        }

        public QueryPermissionByUserIdResponseBodyPermissionDTOList setActionIdList(java.util.List<String> actionIdList) {
            this.actionIdList = actionIdList;
            return this;
        }
        public java.util.List<String> getActionIdList() {
            return this.actionIdList;
        }

        public QueryPermissionByUserIdResponseBodyPermissionDTOList setResourceIdentity(String resourceIdentity) {
            this.resourceIdentity = resourceIdentity;
            return this;
        }
        public String getResourceIdentity() {
            return this.resourceIdentity;
        }

    }

}
