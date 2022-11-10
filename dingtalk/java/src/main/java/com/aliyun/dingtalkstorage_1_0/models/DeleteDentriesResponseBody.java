// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class DeleteDentriesResponseBody extends TeaModel {
    // 批量删除文件结果列表
    // 最大size:
    // 	50
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
        // 是否是异步任务
        // 如果操作对象有子节点，则会异步处理
        @NameInMap("async")
        public Boolean async;

        // 源文件(夹)id
        @NameInMap("dentryId")
        public String dentryId;

        // 错误原因, 如果为异步任务, 该字段为空
        @NameInMap("errorCode")
        public String errorCode;

        // 源文件(夹)空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 是否成功, 如果为异步任务, 该字段为空
        @NameInMap("success")
        public Boolean success;

        // 异步任务id，用于查询任务执行状态
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
