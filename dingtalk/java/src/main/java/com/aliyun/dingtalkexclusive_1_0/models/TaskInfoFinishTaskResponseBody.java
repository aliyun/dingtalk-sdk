// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoFinishTaskResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public Object data;

    @NameInMap("message")
    public String message;

    public static TaskInfoFinishTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoFinishTaskResponseBody self = new TaskInfoFinishTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public TaskInfoFinishTaskResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public TaskInfoFinishTaskResponseBody setData(Object data) {
        this.data = data;
        return this;
    }
    public Object getData() {
        return this.data;
    }

    public TaskInfoFinishTaskResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

}
