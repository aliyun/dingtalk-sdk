// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectMembersV3ResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<CreateProjectMembersV3ResponseBodyResult> result;

    public static CreateProjectMembersV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectMembersV3ResponseBody self = new CreateProjectMembersV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateProjectMembersV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public CreateProjectMembersV3ResponseBody setResult(java.util.List<CreateProjectMembersV3ResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<CreateProjectMembersV3ResponseBodyResult> getResult() {
        return this.result;
    }

    public static class CreateProjectMembersV3ResponseBodyResult extends TeaModel {
        @NameInMap("boundToObjectId")
        public String boundToObjectId;

        @NameInMap("boundToObjectType")
        public String boundToObjectType;

        @NameInMap("joined")
        public String joined;

        @NameInMap("role")
        public Integer role;

        @NameInMap("userId")
        public String userId;

        public static CreateProjectMembersV3ResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateProjectMembersV3ResponseBodyResult self = new CreateProjectMembersV3ResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateProjectMembersV3ResponseBodyResult setBoundToObjectId(String boundToObjectId) {
            this.boundToObjectId = boundToObjectId;
            return this;
        }
        public String getBoundToObjectId() {
            return this.boundToObjectId;
        }

        public CreateProjectMembersV3ResponseBodyResult setBoundToObjectType(String boundToObjectType) {
            this.boundToObjectType = boundToObjectType;
            return this;
        }
        public String getBoundToObjectType() {
            return this.boundToObjectType;
        }

        public CreateProjectMembersV3ResponseBodyResult setJoined(String joined) {
            this.joined = joined;
            return this;
        }
        public String getJoined() {
            return this.joined;
        }

        public CreateProjectMembersV3ResponseBodyResult setRole(Integer role) {
            this.role = role;
            return this;
        }
        public Integer getRole() {
            return this.role;
        }

        public CreateProjectMembersV3ResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
