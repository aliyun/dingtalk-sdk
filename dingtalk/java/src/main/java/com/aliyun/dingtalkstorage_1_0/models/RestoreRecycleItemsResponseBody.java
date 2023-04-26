// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemsResponseBody extends TeaModel {
    @NameInMap("resultItems")
    public java.util.List<RestoreRecycleItemsResponseBodyResultItems> resultItems;

    public static RestoreRecycleItemsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RestoreRecycleItemsResponseBody self = new RestoreRecycleItemsResponseBody();
        return TeaModel.build(map, self);
    }

    public RestoreRecycleItemsResponseBody setResultItems(java.util.List<RestoreRecycleItemsResponseBodyResultItems> resultItems) {
        this.resultItems = resultItems;
        return this;
    }
    public java.util.List<RestoreRecycleItemsResponseBodyResultItems> getResultItems() {
        return this.resultItems;
    }

    public static class RestoreRecycleItemsResponseBodyResultItems extends TeaModel {
        @NameInMap("async")
        public Boolean async;

        @NameInMap("dentryId")
        public String dentryId;

        @NameInMap("errorCode")
        public String errorCode;

        @NameInMap("recycleBinId")
        public String recycleBinId;

        @NameInMap("recycleItemId")
        public String recycleItemId;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("success")
        public Boolean success;

        @NameInMap("taskId")
        public String taskId;

        public static RestoreRecycleItemsResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            RestoreRecycleItemsResponseBodyResultItems self = new RestoreRecycleItemsResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public RestoreRecycleItemsResponseBodyResultItems setAsync(Boolean async) {
            this.async = async;
            return this;
        }
        public Boolean getAsync() {
            return this.async;
        }

        public RestoreRecycleItemsResponseBodyResultItems setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public RestoreRecycleItemsResponseBodyResultItems setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public RestoreRecycleItemsResponseBodyResultItems setRecycleBinId(String recycleBinId) {
            this.recycleBinId = recycleBinId;
            return this;
        }
        public String getRecycleBinId() {
            return this.recycleBinId;
        }

        public RestoreRecycleItemsResponseBodyResultItems setRecycleItemId(String recycleItemId) {
            this.recycleItemId = recycleItemId;
            return this;
        }
        public String getRecycleItemId() {
            return this.recycleItemId;
        }

        public RestoreRecycleItemsResponseBodyResultItems setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public RestoreRecycleItemsResponseBodyResultItems setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

        public RestoreRecycleItemsResponseBodyResultItems setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
