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
        /**
         * <strong>example:</strong>
         * <p>RUNNING</p>
         */
        @NameInMap("businessId")
        public String businessId;

        @NameInMap("canRedirect")
        public Boolean canRedirect;

        @NameInMap("createTime")
        public Long createTime;

        /**
         * <strong>example:</strong>
         * <p>act_0001</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <strong>example:</strong>
         * <p>Siw2WNVZS4KiUt3tTmaNKg04*****809950</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>1234567</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>manager001</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p>2022-10-17T15:12Z</p>
         */
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
