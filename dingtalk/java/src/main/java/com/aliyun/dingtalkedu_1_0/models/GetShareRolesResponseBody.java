// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetShareRolesResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetShareRolesResponseBodyResult> result;

    public static GetShareRolesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetShareRolesResponseBody self = new GetShareRolesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetShareRolesResponseBody setResult(java.util.List<GetShareRolesResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetShareRolesResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetShareRolesResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>123214123</p>
         */
        @NameInMap("shareRoleCode")
        public String shareRoleCode;

        /**
         * <strong>example:</strong>
         * <p>校长</p>
         */
        @NameInMap("shareRoleName")
        public String shareRoleName;

        public static GetShareRolesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetShareRolesResponseBodyResult self = new GetShareRolesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetShareRolesResponseBodyResult setShareRoleCode(String shareRoleCode) {
            this.shareRoleCode = shareRoleCode;
            return this;
        }
        public String getShareRoleCode() {
            return this.shareRoleCode;
        }

        public GetShareRolesResponseBodyResult setShareRoleName(String shareRoleName) {
            this.shareRoleName = shareRoleName;
            return this;
        }
        public String getShareRoleName() {
            return this.shareRoleName;
        }

    }

}
