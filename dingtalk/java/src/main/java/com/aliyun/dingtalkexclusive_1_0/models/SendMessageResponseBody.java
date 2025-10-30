// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SendMessageResponseBody extends TeaModel {
    @NameInMap("errmsg")
    public String errmsg;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("errorcode")
    public String errorcode;

    @NameInMap("task_id")
    public String taskId;

    public static SendMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendMessageResponseBody self = new SendMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendMessageResponseBody setErrmsg(String errmsg) {
        this.errmsg = errmsg;
        return this;
    }
    public String getErrmsg() {
        return this.errmsg;
    }

    public SendMessageResponseBody setErrorcode(String errorcode) {
        this.errorcode = errorcode;
        return this;
    }
    public String getErrorcode() {
        return this.errorcode;
    }

    public SendMessageResponseBody setTaskId(String taskId) {
        this.taskId = taskId;
        return this;
    }
    public String getTaskId() {
        return this.taskId;
    }

}
