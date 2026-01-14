// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class WeiqiaoAluminumSubmitResponseBody extends TeaModel {
    @NameInMap("code")
    public Long code;

    @NameInMap("message")
    public String message;

    @NameInMap("success")
    public Boolean success;

    /**
     * <strong>example:</strong>
     * <p>xxx</p>
     */
    @NameInMap("task_id")
    public String taskId;

    public static WeiqiaoAluminumSubmitResponseBody build(java.util.Map<String, ?> map) throws Exception {
        WeiqiaoAluminumSubmitResponseBody self = new WeiqiaoAluminumSubmitResponseBody();
        return TeaModel.build(map, self);
    }

    public WeiqiaoAluminumSubmitResponseBody setCode(Long code) {
        this.code = code;
        return this;
    }
    public Long getCode() {
        return this.code;
    }

    public WeiqiaoAluminumSubmitResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public WeiqiaoAluminumSubmitResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public WeiqiaoAluminumSubmitResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
