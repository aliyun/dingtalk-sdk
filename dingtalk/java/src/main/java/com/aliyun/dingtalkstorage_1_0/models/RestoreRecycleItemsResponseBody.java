// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RestoreRecycleItemsResponseBody extends TeaModel {
    /**
     * <p>批量还原文件(夹)结果列表</p>
     * <p>最大size:</p>
     * <p>	30</p>
     */
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
        /**
         * <p>是否是异步任务</p>
         * <p>如果操作对象有子节点，则会异步处理</p>
         */
        @NameInMap("async")
        public Boolean async;

        /**
         * <p>操作对应根节点还原之后的文件id</p>
         * <p>非失败的情况下同步或者异步都会返回</p>
         */
        @NameInMap("dentryId")
        public String dentryId;

        /**
         * <p>错误原因, 异步任务该字段不返回</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <p>回收站id</p>
         * <p>可以通过GetRecycleBin API获取</p>
         */
        @NameInMap("recycleBinId")
        public String recycleBinId;

        /**
         * <p>回收项id</p>
         */
        @NameInMap("recycleItemId")
        public String recycleItemId;

        /**
         * <p>操作对应根节点还原之后的空间id</p>
         * <p>非失败的情况下同步或者异步都会返回</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>是否成功, 异步任务该字段不返回</p>
         */
        @NameInMap("success")
        public Boolean success;

        /**
         * <p>异步任务id，用于查询任务执行状态</p>
         */
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
