// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class CopyDentriesResponseBody extends TeaModel {
    @NameInMap("resultItems")
    public java.util.List<CopyDentriesResponseBodyResultItems> resultItems;

    public static CopyDentriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyDentriesResponseBody self = new CopyDentriesResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyDentriesResponseBody setResultItems(java.util.List<CopyDentriesResponseBodyResultItems> resultItems) {
        this.resultItems = resultItems;
        return this;
    }
    public java.util.List<CopyDentriesResponseBodyResultItems> getResultItems() {
        return this.resultItems;
    }

    public static class CopyDentriesResponseBodyResultItems extends TeaModel {
        @NameInMap("async")
        public Boolean async;

        @NameInMap("dentryId")
        public String dentryId;

        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("success")
        public Boolean success;

        @NameInMap("targetDentryId")
        public String targetDentryId;

        @NameInMap("targetSpaceId")
        public String targetSpaceId;

        @NameInMap("taskId")
        public String taskId;

        public static CopyDentriesResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            CopyDentriesResponseBodyResultItems self = new CopyDentriesResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public CopyDentriesResponseBodyResultItems setAsync(Boolean async) {
            this.async = async;
            return this;
        }
        public Boolean getAsync() {
            return this.async;
        }

        public CopyDentriesResponseBodyResultItems setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public CopyDentriesResponseBodyResultItems setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public CopyDentriesResponseBodyResultItems setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public CopyDentriesResponseBodyResultItems setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public CopyDentriesResponseBodyResultItems setTargetDentryId(String targetDentryId) {
            this.targetDentryId = targetDentryId;
            return this;
        }
        public String getTargetDentryId() {
            return this.targetDentryId;
        }

        public CopyDentriesResponseBodyResultItems setTargetSpaceId(String targetSpaceId) {
            this.targetSpaceId = targetSpaceId;
            return this;
        }
        public String getTargetSpaceId() {
            return this.targetSpaceId;
        }

        public CopyDentriesResponseBodyResultItems setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
