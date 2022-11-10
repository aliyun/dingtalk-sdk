// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class CopyDentriesResponseBody extends TeaModel {
    // 批量复制文件(夹)结果列表
    // 最大size:
    // 	30
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

        // 操作对应根节点复制之后的文件id
        // 非失败的情况下同步或者异步都会返回
        @NameInMap("targetDentryId")
        public String targetDentryId;

        // 操作对应根节点复制之后的空间id
        // 非失败的情况下同步或者异步都会返回
        @NameInMap("targetSpaceId")
        public String targetSpaceId;

        // 异步任务id，用于查询任务执行状态
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
