// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class GetProjectMembersV3ResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<GetProjectMembersV3ResponseBodyResult> result;

    public static GetProjectMembersV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProjectMembersV3ResponseBody self = new GetProjectMembersV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProjectMembersV3ResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetProjectMembersV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetProjectMembersV3ResponseBody setResult(java.util.List<GetProjectMembersV3ResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetProjectMembersV3ResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetProjectMembersV3ResponseBodyResult extends TeaModel {
        @NameInMap("role")
        public Integer role;

        @NameInMap("userId")
        public String userId;

        public static GetProjectMembersV3ResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetProjectMembersV3ResponseBodyResult self = new GetProjectMembersV3ResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetProjectMembersV3ResponseBodyResult setRole(Integer role) {
            this.role = role;
            return this;
        }
        public Integer getRole() {
            return this.role;
        }

        public GetProjectMembersV3ResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
