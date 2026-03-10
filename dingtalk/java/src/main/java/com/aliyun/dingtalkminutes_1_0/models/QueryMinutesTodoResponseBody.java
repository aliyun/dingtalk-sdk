// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesTodoResponseBody extends TeaModel {
    @NameInMap("actions")
    public java.util.List<String> actions;

    @NameInMap("dingtalkTodoList")
    public java.util.List<QueryMinutesTodoResponseBodyDingtalkTodoList> dingtalkTodoList;

    public static QueryMinutesTodoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesTodoResponseBody self = new QueryMinutesTodoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesTodoResponseBody setActions(java.util.List<String> actions) {
        this.actions = actions;
        return this;
    }
    public java.util.List<String> getActions() {
        return this.actions;
    }

    public QueryMinutesTodoResponseBody setDingtalkTodoList(java.util.List<QueryMinutesTodoResponseBodyDingtalkTodoList> dingtalkTodoList) {
        this.dingtalkTodoList = dingtalkTodoList;
        return this;
    }
    public java.util.List<QueryMinutesTodoResponseBodyDingtalkTodoList> getDingtalkTodoList() {
        return this.dingtalkTodoList;
    }

    public static class QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList extends TeaModel {
        @NameInMap("avatar")
        public String avatar;

        @NameInMap("nick")
        public String nick;

        @NameInMap("unionId")
        public String unionId;

        public static QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList self = new QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList();
            return TeaModel.build(map, self);
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

    }

    public static class QueryMinutesTodoResponseBodyDingtalkTodoList extends TeaModel {
        @NameInMap("createdTime")
        public Long createdTime;

        @NameInMap("creatorUnionId")
        public String creatorUnionId;

        @NameInMap("deadline")
        public String deadline;

        @NameInMap("dingtalkTodoId")
        public String dingtalkTodoId;

        @NameInMap("executorList")
        public java.util.List<QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList> executorList;

        @NameInMap("isDone")
        public Boolean isDone;

        @NameInMap("minutesTodoId")
        public String minutesTodoId;

        @NameInMap("title")
        public String title;

        public static QueryMinutesTodoResponseBodyDingtalkTodoList build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesTodoResponseBodyDingtalkTodoList self = new QueryMinutesTodoResponseBodyDingtalkTodoList();
            return TeaModel.build(map, self);
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoList setCreatedTime(Long createdTime) {
            this.createdTime = createdTime;
            return this;
        }
        public Long getCreatedTime() {
            return this.createdTime;
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoList setCreatorUnionId(String creatorUnionId) {
            this.creatorUnionId = creatorUnionId;
            return this;
        }
        public String getCreatorUnionId() {
            return this.creatorUnionId;
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoList setDeadline(String deadline) {
            this.deadline = deadline;
            return this;
        }
        public String getDeadline() {
            return this.deadline;
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoList setDingtalkTodoId(String dingtalkTodoId) {
            this.dingtalkTodoId = dingtalkTodoId;
            return this;
        }
        public String getDingtalkTodoId() {
            return this.dingtalkTodoId;
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoList setExecutorList(java.util.List<QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList> executorList) {
            this.executorList = executorList;
            return this;
        }
        public java.util.List<QueryMinutesTodoResponseBodyDingtalkTodoListExecutorList> getExecutorList() {
            return this.executorList;
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoList setIsDone(Boolean isDone) {
            this.isDone = isDone;
            return this;
        }
        public Boolean getIsDone() {
            return this.isDone;
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoList setMinutesTodoId(String minutesTodoId) {
            this.minutesTodoId = minutesTodoId;
            return this;
        }
        public String getMinutesTodoId() {
            return this.minutesTodoId;
        }

        public QueryMinutesTodoResponseBodyDingtalkTodoList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
