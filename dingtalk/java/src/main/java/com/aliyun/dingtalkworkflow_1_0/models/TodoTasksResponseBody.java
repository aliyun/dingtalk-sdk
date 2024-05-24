// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class TodoTasksResponseBody extends TeaModel {
    @NameInMap("result")
    public TodoTasksResponseBodyResult result;

    public static TodoTasksResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TodoTasksResponseBody self = new TodoTasksResponseBody();
        return TeaModel.build(map, self);
    }

    public TodoTasksResponseBody setResult(TodoTasksResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public TodoTasksResponseBodyResult getResult() {
        return this.result;
    }

    public static class TodoTasksResponseBodyResultList extends TeaModel {
        @NameInMap("businessId")
        public String businessId;

        @NameInMap("canRedirect")
        public Boolean canRedirect;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("processCode")
        public String processCode;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("taskId")
        public Long taskId;

        @NameInMap("title")
        public String title;

        @NameInMap("userId")
        public String userId;

        public static TodoTasksResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            TodoTasksResponseBodyResultList self = new TodoTasksResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public TodoTasksResponseBodyResultList setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public TodoTasksResponseBodyResultList setCanRedirect(Boolean canRedirect) {
            this.canRedirect = canRedirect;
            return this;
        }
        public Boolean getCanRedirect() {
            return this.canRedirect;
        }

        public TodoTasksResponseBodyResultList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public TodoTasksResponseBodyResultList setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public TodoTasksResponseBodyResultList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public TodoTasksResponseBodyResultList setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public TodoTasksResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public TodoTasksResponseBodyResultList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class TodoTasksResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<TodoTasksResponseBodyResultList> list;

        public static TodoTasksResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            TodoTasksResponseBodyResult self = new TodoTasksResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public TodoTasksResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public TodoTasksResponseBodyResult setList(java.util.List<TodoTasksResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<TodoTasksResponseBodyResultList> getList() {
            return this.list;
        }

    }

}
