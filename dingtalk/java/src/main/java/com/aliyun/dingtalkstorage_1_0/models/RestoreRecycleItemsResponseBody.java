// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemsResponseBody extends TeaModel {
    // 批量还原文件(夹)结果列表
    // 最大size:
    // 	30
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
        // 是否是异步任务
        // 如果操作对象有子节点，则会异步处理
        @NameInMap("async")
        public Boolean async;

        // 操作对应根节点还原之后的文件id
        // 非失败的情况下同步或者异步都会返回
        @NameInMap("dentryId")
        public String dentryId;

        // 错误原因, 异步任务该字段不返回
        @NameInMap("errorCode")
        public String errorCode;

        // 回收站id
        // 可以通过GetRecycleBin API获取
        @NameInMap("recycleBinId")
        public String recycleBinId;

        // 回收项id
        @NameInMap("recycleItemId")
        public String recycleItemId;

        // 操作对应根节点还原之后的空间id
        // 非失败的情况下同步或者异步都会返回
        @NameInMap("spaceId")
        public String spaceId;

        // 是否成功, 异步任务该字段不返回
        @NameInMap("success")
        public Boolean success;

        // 异步任务id，用于查询任务执行状态
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
