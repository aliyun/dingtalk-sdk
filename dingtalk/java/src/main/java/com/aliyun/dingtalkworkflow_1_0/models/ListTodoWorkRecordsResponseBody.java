// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListTodoWorkRecordsResponseBody extends TeaModel {
    /**
     * <p>查询结果。</p>
     */
    @NameInMap("result")
    public ListTodoWorkRecordsResponseBodyResult result;

    public static ListTodoWorkRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListTodoWorkRecordsResponseBody self = new ListTodoWorkRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListTodoWorkRecordsResponseBody setResult(ListTodoWorkRecordsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListTodoWorkRecordsResponseBodyResult getResult() {
        return this.result;
    }

    public static class ListTodoWorkRecordsResponseBodyResultListForms extends TeaModel {
        /**
         * <p>表单内容。</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <p>表单标题。</p>
         */
        @NameInMap("title")
        public String title;

        public static ListTodoWorkRecordsResponseBodyResultListForms build(java.util.Map<String, ?> map) throws Exception {
            ListTodoWorkRecordsResponseBodyResultListForms self = new ListTodoWorkRecordsResponseBodyResultListForms();
            return TeaModel.build(map, self);
        }

        public ListTodoWorkRecordsResponseBodyResultListForms setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public ListTodoWorkRecordsResponseBodyResultListForms setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class ListTodoWorkRecordsResponseBodyResultList extends TeaModel {
        /**
         * <p>表单列表。</p>
         */
        @NameInMap("forms")
        public java.util.List<ListTodoWorkRecordsResponseBodyResultListForms> forms;

        /**
         * <p>实例ID。</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <p>待办任务ID。</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <p>待办标题。</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>待办跳转链接。</p>
         */
        @NameInMap("url")
        public String url;

        public static ListTodoWorkRecordsResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            ListTodoWorkRecordsResponseBodyResultList self = new ListTodoWorkRecordsResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public ListTodoWorkRecordsResponseBodyResultList setForms(java.util.List<ListTodoWorkRecordsResponseBodyResultListForms> forms) {
            this.forms = forms;
            return this;
        }
        public java.util.List<ListTodoWorkRecordsResponseBodyResultListForms> getForms() {
            return this.forms;
        }

        public ListTodoWorkRecordsResponseBodyResultList setInstanceId(String instanceId) {
            this.instanceId = instanceId;
            return this;
        }
        public String getInstanceId() {
            return this.instanceId;
        }

        public ListTodoWorkRecordsResponseBodyResultList setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public ListTodoWorkRecordsResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public ListTodoWorkRecordsResponseBodyResultList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class ListTodoWorkRecordsResponseBodyResult extends TeaModel {
        /**
         * <p>待办事项列表。</p>
         */
        @NameInMap("list")
        public java.util.List<ListTodoWorkRecordsResponseBodyResultList> list;

        /**
         * <p>分页游标。不为空表示有数据。</p>
         */
        @NameInMap("nextToken")
        public Long nextToken;

        public static ListTodoWorkRecordsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListTodoWorkRecordsResponseBodyResult self = new ListTodoWorkRecordsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListTodoWorkRecordsResponseBodyResult setList(java.util.List<ListTodoWorkRecordsResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<ListTodoWorkRecordsResponseBodyResultList> getList() {
            return this.list;
        }

        public ListTodoWorkRecordsResponseBodyResult setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

    }

}
