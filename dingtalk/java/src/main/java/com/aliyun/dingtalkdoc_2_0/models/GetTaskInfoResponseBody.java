// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetTaskInfoResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("failCount")
    public Integer failCount;

    /**
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("succCount")
    public Integer succCount;

    /**
     * <strong>example:</strong>
     * <p>abcd</p>
     */
    @NameInMap("taskId")
    public String taskId;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("totalCount")
    public Integer totalCount;

    public static GetTaskInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTaskInfoResponseBody self = new GetTaskInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTaskInfoResponseBody setFailCount(Integer failCount) {
        this.failCount = failCount;
        return this;
    }
    public Integer getFailCount() {
        return this.failCount;
    }

    public GetTaskInfoResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetTaskInfoResponseBody setSuccCount(Integer succCount) {
        this.succCount = succCount;
        return this;
    }
    public Integer getSuccCount() {
        return this.succCount;
    }

    public GetTaskInfoResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

    public GetTaskInfoResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

}
