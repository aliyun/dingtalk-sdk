// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetATManageScopeResponseBody extends TeaModel {
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
         * <p>This parameter is required.</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("manageScope")
        public String manageScope;

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
