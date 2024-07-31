// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoAddDelTaskPersonResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public Object data;

    @NameInMap("message")
    public String message;

    public static TaskInfoAddDelTaskPersonResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoAddDelTaskPersonResponseBody self = new TaskInfoAddDelTaskPersonResponseBody();
        return TeaModel.build(map, self);
    }

    public TaskInfoAddDelTaskPersonResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public TaskInfoAddDelTaskPersonResponseBody setData(Object data) {
        this.data = data;
        return this;
    }
    public Object getData() {
        return this.data;
    }

    public TaskInfoAddDelTaskPersonResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

}
