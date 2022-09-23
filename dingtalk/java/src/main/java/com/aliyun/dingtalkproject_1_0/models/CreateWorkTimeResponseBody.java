// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkTimeResponseBody extends TeaModel {
    @NameInMap("result")
    public CreateWorkTimeResponseBodyResult result;

    public static CreateWorkTimeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkTimeResponseBody self = new CreateWorkTimeResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateWorkTimeResponseBody setResult(CreateWorkTimeResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CreateWorkTimeResponseBodyResult getResult() {
        return this.result;
    }

    public static class CreateWorkTimeResponseBodyResultBody extends TeaModel {
        // 工时所属日期
        @NameInMap("date")
        public String date;

        // 工时关联的数据 ID
        @NameInMap("taskId")
        public String taskId;

        // 实际工时
        @NameInMap("workTime")
        public Long workTime;

        public static CreateWorkTimeResponseBodyResultBody build(java.util.Map<String, ?> map) throws Exception {
            CreateWorkTimeResponseBodyResultBody self = new CreateWorkTimeResponseBodyResultBody();
            return TeaModel.build(map, self);
        }

        public CreateWorkTimeResponseBodyResultBody setDate(String date) {
            this.date = date;
            return this;
        }
        public String getDate() {
            return this.date;
        }

        public CreateWorkTimeResponseBodyResultBody setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public CreateWorkTimeResponseBodyResultBody setWorkTime(Long workTime) {
            this.workTime = workTime;
            return this;
        }
        public Long getWorkTime() {
            return this.workTime;
        }

    }

    public static class CreateWorkTimeResponseBodyResult extends TeaModel {
        @NameInMap("body")
        public java.util.List<CreateWorkTimeResponseBodyResultBody> body;

        // 执行结果描述
        @NameInMap("message")
        public String message;

        @NameInMap("ok")
        public Boolean ok;

        public static CreateWorkTimeResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CreateWorkTimeResponseBodyResult self = new CreateWorkTimeResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CreateWorkTimeResponseBodyResult setBody(java.util.List<CreateWorkTimeResponseBodyResultBody> body) {
            this.body = body;
            return this;
        }
        public java.util.List<CreateWorkTimeResponseBodyResultBody> getBody() {
            return this.body;
        }

        public CreateWorkTimeResponseBodyResult setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
        }

        public CreateWorkTimeResponseBodyResult setOk(Boolean ok) {
            this.ok = ok;
            return this;
        }
        public Boolean getOk() {
            return this.ok;
        }

    }

}
