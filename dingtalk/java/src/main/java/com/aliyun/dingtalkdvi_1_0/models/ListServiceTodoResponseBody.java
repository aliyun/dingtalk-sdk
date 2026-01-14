// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListServiceTodoResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<ListServiceTodoResponseBodyResult> result;

    public static ListServiceTodoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListServiceTodoResponseBody self = new ListServiceTodoResponseBody();
        return TeaModel.build(map, self);
    }

    public ListServiceTodoResponseBody setResult(java.util.List<ListServiceTodoResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<ListServiceTodoResponseBodyResult> getResult() {
        return this.result;
    }

    public static class ListServiceTodoResponseBodyResultExecutors extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static ListServiceTodoResponseBodyResultExecutors build(java.util.Map<String, ?> map) throws Exception {
            ListServiceTodoResponseBodyResultExecutors self = new ListServiceTodoResponseBodyResultExecutors();
            return TeaModel.build(map, self);
        }

        public ListServiceTodoResponseBodyResultExecutors setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListServiceTodoResponseBodyResultExecutors setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class ListServiceTodoResponseBodyResult extends TeaModel {
        @NameInMap("creator")
        public String creator;

        @NameInMap("dingTodoId")
        public String dingTodoId;

        @NameInMap("executors")
        public java.util.List<ListServiceTodoResponseBodyResultExecutors> executors;

        @NameInMap("finished")
        public Boolean finished;

        @NameInMap("planFinishDate")
        public Long planFinishDate;

        @NameInMap("todoContent")
        public String todoContent;

        @NameInMap("uuid")
        public String uuid;

        public static ListServiceTodoResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListServiceTodoResponseBodyResult self = new ListServiceTodoResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListServiceTodoResponseBodyResult setCreator(String creator) {
            this.creator = creator;
            return this;
        }
        public String getCreator() {
            return this.creator;
        }

        public ListServiceTodoResponseBodyResult setDingTodoId(String dingTodoId) {
            this.dingTodoId = dingTodoId;
            return this;
        }
        public String getDingTodoId() {
            return this.dingTodoId;
        }

        public ListServiceTodoResponseBodyResult setExecutors(java.util.List<ListServiceTodoResponseBodyResultExecutors> executors) {
            this.executors = executors;
            return this;
        }
        public java.util.List<ListServiceTodoResponseBodyResultExecutors> getExecutors() {
            return this.executors;
        }

        public ListServiceTodoResponseBodyResult setFinished(Boolean finished) {
            this.finished = finished;
            return this;
        }
        public Boolean getFinished() {
            return this.finished;
        }

        public ListServiceTodoResponseBodyResult setPlanFinishDate(Long planFinishDate) {
            this.planFinishDate = planFinishDate;
            return this;
        }
        public Long getPlanFinishDate() {
            return this.planFinishDate;
        }

        public ListServiceTodoResponseBodyResult setTodoContent(String todoContent) {
            this.todoContent = todoContent;
            return this;
        }
        public String getTodoContent() {
            return this.todoContent;
        }

        public ListServiceTodoResponseBodyResult setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

    }

}
