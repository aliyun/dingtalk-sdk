// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class DeleteProjectMembersV3ResponseBody extends TeaModel {
    @NameInMap("errors")
    public java.util.List<DeleteProjectMembersV3ResponseBodyErrors> errors;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<String> result;

    public static DeleteProjectMembersV3ResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteProjectMembersV3ResponseBody self = new DeleteProjectMembersV3ResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteProjectMembersV3ResponseBody setErrors(java.util.List<DeleteProjectMembersV3ResponseBodyErrors> errors) {
        this.errors = errors;
        return this;
    }
    public java.util.List<DeleteProjectMembersV3ResponseBodyErrors> getErrors() {
        return this.errors;
    }

    public DeleteProjectMembersV3ResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public DeleteProjectMembersV3ResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

    public static class DeleteProjectMembersV3ResponseBodyErrors extends TeaModel {
        @NameInMap("message")
        public String message;

        public static DeleteProjectMembersV3ResponseBodyErrors build(java.util.Map<String, ?> map) throws Exception {
            DeleteProjectMembersV3ResponseBodyErrors self = new DeleteProjectMembersV3ResponseBodyErrors();
            return TeaModel.build(map, self);
        }

        public DeleteProjectMembersV3ResponseBodyErrors setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

    }

}
