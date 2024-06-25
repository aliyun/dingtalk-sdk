// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class CreateProcessesInstanceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>success</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public CreateProcessesInstanceResponseBodyData data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OK</p>
     */
    @NameInMap("message")
    public String message;

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

    public CreateProcessesInstanceResponseBody setData(CreateProcessesInstanceResponseBodyData data) {
        this.data = data;
        return this;
    }
    public CreateProcessesInstanceResponseBodyData getData() {
        return this.data;
    }

    public CreateProcessesInstanceResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class CreateProcessesInstanceResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>3d0ad4a4-d7d5-4196-9f2c-3ed246f2b713</p>
         */
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
