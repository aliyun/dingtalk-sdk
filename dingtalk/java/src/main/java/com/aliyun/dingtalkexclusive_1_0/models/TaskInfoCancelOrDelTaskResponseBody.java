// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoCancelOrDelTaskResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public Object data;

    @NameInMap("message")
    public String message;

    public static TaskInfoCancelOrDelTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoCancelOrDelTaskResponseBody self = new TaskInfoCancelOrDelTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public TaskInfoCancelOrDelTaskResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public TaskInfoCancelOrDelTaskResponseBody setData(Object data) {
        this.data = data;
        return this;
    }
    public Object getData() {
        return this.data;
    }

    public TaskInfoCancelOrDelTaskResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

}
