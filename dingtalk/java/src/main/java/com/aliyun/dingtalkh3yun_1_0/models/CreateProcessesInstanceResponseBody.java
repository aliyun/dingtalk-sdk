// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateProcessesInstanceResponseBody extends TeaModel {
    // 状态码
    @NameInMap("code")
    public String code;

    // 提示信息
    @NameInMap("message")
    public String message;

    // 业务响应结果
    @NameInMap("data")
    public CreateProcessesInstanceResponseBodyData data;

    public static CreateProcessesInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateProcessesInstanceResponseBody self = new CreateProcessesInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateProcessesInstanceResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CreateProcessesInstanceResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public CreateProcessesInstanceResponseBody setData(CreateProcessesInstanceResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateProcessesInstanceResponseBodyData getData() {
        return this.data;
    }

    public static class CreateProcessesInstanceResponseBodyData extends TeaModel {
        // 流程实例ID
        @NameInMap("processInstanceId")
        public String processInstanceId;

        public static CreateProcessesInstanceResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            CreateProcessesInstanceResponseBodyData self = new CreateProcessesInstanceResponseBodyData();
            return TeaModel.build(map, self);
        }

        public CreateProcessesInstanceResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

    }

}
