// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentriesResponseBody extends TeaModel {
    @NameInMap("resultItems")
    public java.util.List<DeleteDentriesResponseBodyResultItems> resultItems;

    public static DeleteDentriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteDentriesResponseBody self = new DeleteDentriesResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteDentriesResponseBody setResultItems(java.util.List<DeleteDentriesResponseBodyResultItems> resultItems) {
        this.resultItems = resultItems;
        return this;
    }
    public java.util.List<DeleteDentriesResponseBodyResultItems> getResultItems() {
        return this.resultItems;
    }

    public static class DeleteDentriesResponseBodyResultItems extends TeaModel {
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

        @NameInMap("taskId")
        public String taskId;

        public static DeleteDentriesResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            DeleteDentriesResponseBodyResultItems self = new DeleteDentriesResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public DeleteDentriesResponseBodyResultItems setAsync(Boolean async) {
            this.async = async;
            return this;
        }
        public Boolean getAsync() {
            return this.async;
        }

        public DeleteDentriesResponseBodyResultItems setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public DeleteDentriesResponseBodyResultItems setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public DeleteDentriesResponseBodyResultItems setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public DeleteDentriesResponseBodyResultItems setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public DeleteDentriesResponseBodyResultItems setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
