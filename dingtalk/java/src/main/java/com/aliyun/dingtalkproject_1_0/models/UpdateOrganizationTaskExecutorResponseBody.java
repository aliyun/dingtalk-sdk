// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateOrganizationTaskExecutorResponseBody extends TeaModel {
    @NameInMap("result")
    public UpdateOrganizationTaskExecutorResponseBodyResult result;

    public static UpdateOrganizationTaskExecutorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateOrganizationTaskExecutorResponseBody self = new UpdateOrganizationTaskExecutorResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateOrganizationTaskExecutorResponseBody setResult(UpdateOrganizationTaskExecutorResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateOrganizationTaskExecutorResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateOrganizationTaskExecutorResponseBodyResultExecutor extends TeaModel {
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static UpdateOrganizationTaskExecutorResponseBodyResultExecutor build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskExecutorResponseBodyResultExecutor self = new UpdateOrganizationTaskExecutorResponseBodyResultExecutor();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskExecutorResponseBodyResultExecutor setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public UpdateOrganizationTaskExecutorResponseBodyResultExecutor setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateOrganizationTaskExecutorResponseBodyResultExecutor setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class UpdateOrganizationTaskExecutorResponseBodyResultInvolvers extends TeaModel {
        @NameInMap("avatarUrl")
        public String avatarUrl;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static UpdateOrganizationTaskExecutorResponseBodyResultInvolvers build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskExecutorResponseBodyResultInvolvers self = new UpdateOrganizationTaskExecutorResponseBodyResultInvolvers();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskExecutorResponseBodyResultInvolvers setAvatarUrl(String avatarUrl) {
            this.avatarUrl = avatarUrl;
            return this;
        }
        public String getAvatarUrl() {
            return this.avatarUrl;
        }

        public UpdateOrganizationTaskExecutorResponseBodyResultInvolvers setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public UpdateOrganizationTaskExecutorResponseBodyResultInvolvers setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class UpdateOrganizationTaskExecutorResponseBodyResult extends TeaModel {
        @NameInMap("executor")
        public UpdateOrganizationTaskExecutorResponseBodyResultExecutor executor;

        @NameInMap("executorId")
        public String executorId;

        @NameInMap("involvers")
        public java.util.List<UpdateOrganizationTaskExecutorResponseBodyResultInvolvers> involvers;

        @NameInMap("updated")
        public String updated;

        public static UpdateOrganizationTaskExecutorResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateOrganizationTaskExecutorResponseBodyResult self = new UpdateOrganizationTaskExecutorResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateOrganizationTaskExecutorResponseBodyResult setExecutor(UpdateOrganizationTaskExecutorResponseBodyResultExecutor executor) {
            this.executor = executor;
            return this;
        }
        public UpdateOrganizationTaskExecutorResponseBodyResultExecutor getExecutor() {
            return this.executor;
        }

        public UpdateOrganizationTaskExecutorResponseBodyResult setExecutorId(String executorId) {
            this.executorId = executorId;
            return this;
        }
        public String getExecutorId() {
            return this.executorId;
        }

        public UpdateOrganizationTaskExecutorResponseBodyResult setInvolvers(java.util.List<UpdateOrganizationTaskExecutorResponseBodyResultInvolvers> involvers) {
            this.involvers = involvers;
            return this;
        }
        public java.util.List<UpdateOrganizationTaskExecutorResponseBodyResultInvolvers> getInvolvers() {
            return this.involvers;
        }

        public UpdateOrganizationTaskExecutorResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
