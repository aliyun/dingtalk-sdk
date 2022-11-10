// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class MoveDentriesResponseBody extends TeaModel {
    // 批量移动文件(夹)结果列表
    // 最大size:
    // 	30
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
        // 是否是异步任务
        // 如果操作对象有子节点，则会异步处理
        @NameInMap("async")
        public Boolean async;

        // 源文件(夹)id
        @NameInMap("dentryId")
        public String dentryId;

        // 错误原因, 异步任务该字段不返回
        @NameInMap("errorCode")
        public String errorCode;

        // 源文件(夹)空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 是否成功, 异步任务该字段不返回
        @NameInMap("success")
        public Boolean success;

        // 操作对应根节点移动之后的文件id
        // 非失败的情况下同步或者异步都会返回
        @NameInMap("targetDentryId")
        public String targetDentryId;

        // 操作对应根节点移动之后的空间id
        // 非失败的情况下同步或者异步都会返回
        @NameInMap("targetSpaceId")
        public String targetSpaceId;

        // 异步任务id，用于查询任务执行状态
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
