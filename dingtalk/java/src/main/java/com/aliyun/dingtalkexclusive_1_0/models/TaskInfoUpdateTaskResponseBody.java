// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoUpdateTaskResponseBody extends TeaModel {
    @NameInMap("code")
    public Integer code;

    @NameInMap("data")
    public TaskInfoUpdateTaskResponseBodyData data;

    @NameInMap("message")
    public String message;

    public static TaskInfoUpdateTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoUpdateTaskResponseBody self = new TaskInfoUpdateTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public TaskInfoUpdateTaskResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public TaskInfoUpdateTaskResponseBody setData(TaskInfoUpdateTaskResponseBodyData data) {
        this.data = data;
        return this;
    }
    public TaskInfoUpdateTaskResponseBodyData getData() {
        return this.data;
    }

    public TaskInfoUpdateTaskResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class TaskInfoUpdateTaskResponseBodyDataGroupVoList extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        @NameInMap("openConversationId")
        public String openConversationId;

        public static TaskInfoUpdateTaskResponseBodyDataGroupVoList build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoUpdateTaskResponseBodyDataGroupVoList self = new TaskInfoUpdateTaskResponseBodyDataGroupVoList();
            return TeaModel.build(map, self);
        }

        public TaskInfoUpdateTaskResponseBodyDataGroupVoList setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public TaskInfoUpdateTaskResponseBodyDataGroupVoList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

    public static class TaskInfoUpdateTaskResponseBodyData extends TeaModel {
        @NameInMap("groupVoList")
        public java.util.List<TaskInfoUpdateTaskResponseBodyDataGroupVoList> groupVoList;

        @NameInMap("taskId")
        public String taskId;

        public static TaskInfoUpdateTaskResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoUpdateTaskResponseBodyData self = new TaskInfoUpdateTaskResponseBodyData();
            return TeaModel.build(map, self);
        }

        public TaskInfoUpdateTaskResponseBodyData setGroupVoList(java.util.List<TaskInfoUpdateTaskResponseBodyDataGroupVoList> groupVoList) {
            this.groupVoList = groupVoList;
            return this;
        }
        public java.util.List<TaskInfoUpdateTaskResponseBodyDataGroupVoList> getGroupVoList() {
            return this.groupVoList;
        }

        public TaskInfoUpdateTaskResponseBodyData setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

    }

}
