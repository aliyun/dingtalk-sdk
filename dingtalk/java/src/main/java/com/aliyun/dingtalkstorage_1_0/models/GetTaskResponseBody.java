// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetTaskResponseBody extends TeaModel {
    /**
     * <p>任务信息</p>
     */
    @NameInMap("task")
    public GetTaskResponseBodyTask task;

    public static GetTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTaskResponseBody self = new GetTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTaskResponseBody setTask(GetTaskResponseBodyTask task) {
        this.task = task;
        return this;
    }
    public GetTaskResponseBodyTask getTask() {
        return this.task;
    }

    public static class GetTaskResponseBodyTask extends TeaModel {
        /**
         * <p>任务开始时间</p>
         */
        @NameInMap("beginTime")
        public String beginTime;

        /**
         * <p>任务结束时间</p>
         */
        @NameInMap("endTime")
        public String endTime;

        /**
         * <p>子任务失败总数</p>
         */
        @NameInMap("failCount")
        public Long failCount;

        /**
         * <p>任务失败原因</p>
         */
        @NameInMap("failMessage")
        public String failMessage;

        /**
         * <p>任务id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>任务状态</p>
         * <p>枚举值:</p>
         * <p>	INIT: 初始化</p>
         * <p>	IN_PROGRESS: 进行中</p>
         * <p>	SUCCESS: 成功</p>
         * <p>	FAIL: 失败</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>子任务成功总数</p>
         */
        @NameInMap("successCount")
        public Long successCount;

        /**
         * <p>子任务总数</p>
         */
        @NameInMap("totalCount")
        public Long totalCount;

        public static GetTaskResponseBodyTask build(java.util.Map<String, ?> map) throws Exception {
            GetTaskResponseBodyTask self = new GetTaskResponseBodyTask();
            return TeaModel.build(map, self);
        }

        public GetTaskResponseBodyTask setBeginTime(String beginTime) {
            this.beginTime = beginTime;
            return this;
        }
        public String getBeginTime() {
            return this.beginTime;
        }

        public GetTaskResponseBodyTask setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public GetTaskResponseBodyTask setFailCount(Long failCount) {
            this.failCount = failCount;
            return this;
        }
        public Long getFailCount() {
            return this.failCount;
        }

        public GetTaskResponseBodyTask setFailMessage(String failMessage) {
            this.failMessage = failMessage;
            return this;
        }
        public String getFailMessage() {
            return this.failMessage;
        }

        public GetTaskResponseBodyTask setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetTaskResponseBodyTask setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetTaskResponseBodyTask setSuccessCount(Long successCount) {
            this.successCount = successCount;
            return this;
        }
        public Long getSuccessCount() {
            return this.successCount;
        }

        public GetTaskResponseBodyTask setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

}
