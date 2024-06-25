// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentriesResponseBody extends TeaModel {
    @NameInMap("resultItems")
    public java.util.List<MoveDentriesResponseBodyResultItems> resultItems;

    public static MoveDentriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        MoveDentriesResponseBody self = new MoveDentriesResponseBody();
        return TeaModel.build(map, self);
    }

    public MoveDentriesResponseBody setResultItems(java.util.List<MoveDentriesResponseBodyResultItems> resultItems) {
        this.resultItems = resultItems;
        return this;
    }
    public java.util.List<MoveDentriesResponseBodyResultItems> getResultItems() {
        return this.resultItems;
    }

    public static class MoveDentriesResponseBodyResultItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("async")
        public Boolean async;

        /**
         * <strong>example:</strong>
         * <p>dentry_id</p>
         */
        @NameInMap("dentryId")
        public String dentryId;

        /**
         * <strong>example:</strong>
         * <p>permissionDenied</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <strong>example:</strong>
         * <p>space_id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("success")
        public Boolean success;

        /**
         * <strong>example:</strong>
         * <p>target_dentry_id</p>
         */
        @NameInMap("targetDentryId")
        public String targetDentryId;

        /**
         * <strong>example:</strong>
         * <p>target_space_id</p>
         */
        @NameInMap("targetSpaceId")
        public String targetSpaceId;

        /**
         * <strong>example:</strong>
         * <p>task_id</p>
         */
        @NameInMap("taskId")
        public String taskId;

        public static MoveDentriesResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            MoveDentriesResponseBodyResultItems self = new MoveDentriesResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public MoveDentriesResponseBodyResultItems setAsync(Boolean async) {
            this.async = async;
            return this;
        }
        public Boolean getAsync() {
            return this.async;
        }

        public MoveDentriesResponseBodyResultItems setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public MoveDentriesResponseBodyResultItems setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public MoveDentriesResponseBodyResultItems setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public MoveDentriesResponseBodyResultItems setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public MoveDentriesResponseBodyResultItems setTargetDentryId(String targetDentryId) {
            this.targetDentryId = targetDentryId;
            return this;
        }
        public String getTargetDentryId() {
            return this.targetDentryId;
        }

        public MoveDentriesResponseBodyResultItems setTargetSpaceId(String targetSpaceId) {
            this.targetSpaceId = targetSpaceId;
            return this;
        }
        public String getTargetSpaceId() {
            return this.targetSpaceId;
        }

        public MoveDentriesResponseBodyResultItems setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
