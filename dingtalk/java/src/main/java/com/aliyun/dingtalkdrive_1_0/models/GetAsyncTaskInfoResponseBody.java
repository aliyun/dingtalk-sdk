// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class GetAsyncTaskInfoResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * <br>
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("beginTime")
    public String beginTime;

    /**
     * <p>This parameter is required.</p>
     * <br>
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("endTime")
    public String endTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("failed")
    public Integer failed;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Integer success;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskId")
    public String taskId;

    @NameInMap("total")
    public Integer total;

    public static GetAsyncTaskInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAsyncTaskInfoResponseBody self = new GetAsyncTaskInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAsyncTaskInfoResponseBody setBeginTime(String beginTime) {
        this.beginTime = beginTime;
        return this;
    }
    public String getBeginTime() {
        return this.beginTime;
    }

    public GetAsyncTaskInfoResponseBody setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public GetAsyncTaskInfoResponseBody setFailed(Integer failed) {
        this.failed = failed;
        return this;
    }
    public Integer getFailed() {
        return this.failed;
    }

    public GetAsyncTaskInfoResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetAsyncTaskInfoResponseBody setSuccess(Integer success) {
        this.success = success;
        return this;
    }
    public Integer getSuccess() {
        return this.success;
    }

    public GetAsyncTaskInfoResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetAsyncTaskInfoResponseBody setTotal(Integer total) {
        this.total = total;
        return this;
    }
    public Integer getTotal() {
        return this.total;
    }

}
