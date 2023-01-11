// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetATManageScopeResponseBody extends TeaModel {
    /**
     * <p>管理范围。</p>
     */
    @NameInMap("result")
    public java.util.List<GetATManageScopeResponseBodyResult> result;

    public static GetATManageScopeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetATManageScopeResponseBody self = new GetATManageScopeResponseBody();
        return TeaModel.build(map, self);
    }

    public GetATManageScopeResponseBody setResult(java.util.List<GetATManageScopeResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetATManageScopeResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetATManageScopeResponseBodyResult extends TeaModel {
        /**
         * <p>是否有更多数据。  true：有  false：没有</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        /**
         * <p>可见范围。boss/主管理员/管理范围包含根部门的管理员：all ，管理员/考勤组负责人：partial，无权限：none</p>
         */
        @NameInMap("manageScope")
        public String manageScope;

        /**
         * <p>员工userid。只有manageScope为partial返回数据。</p>
         */
        @NameInMap("userIds")
        public java.util.List<String> userIds;

        public static GetATManageScopeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetATManageScopeResponseBodyResult self = new GetATManageScopeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetATManageScopeResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetATManageScopeResponseBodyResult setManageScope(String manageScope) {
            this.manageScope = manageScope;
            return this;
        }
        public String getManageScope() {
            return this.manageScope;
        }

        public GetATManageScopeResponseBodyResult setUserIds(java.util.List<String> userIds) {
            this.userIds = userIds;
            return this;
        }
        public java.util.List<String> getUserIds() {
            return this.userIds;
        }

    }

}
