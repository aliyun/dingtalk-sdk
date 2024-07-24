// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoCreateAndStartTaskResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public TaskInfoCreateAndStartTaskResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static TaskInfoCreateAndStartTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoCreateAndStartTaskResponseBody self = new TaskInfoCreateAndStartTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public TaskInfoCreateAndStartTaskResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public TaskInfoCreateAndStartTaskResponseBody setData(TaskInfoCreateAndStartTaskResponseBodyData data) {
        this.data = data;
        return this;
    }
    public TaskInfoCreateAndStartTaskResponseBodyData getData() {
        return this.data;
    }

    public TaskInfoCreateAndStartTaskResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("openConversationId")
        public String openConversationId;

        public static TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList self = new TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

    public static class TaskInfoCreateAndStartTaskResponseBodyData extends TeaModel {
        @NameInMap("groupVoList")
        public java.util.List<TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList> groupVoList;

        @NameInMap("taskId")
        public String taskId;

        public static TaskInfoCreateAndStartTaskResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskResponseBodyData self = new TaskInfoCreateAndStartTaskResponseBodyData();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskResponseBodyData setGroupVoList(java.util.List<TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList> groupVoList) {
            this.groupVoList = groupVoList;
            return this;
        }
        public java.util.List<TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList> getGroupVoList() {
            return this.groupVoList;
        }

        public TaskInfoCreateAndStartTaskResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
