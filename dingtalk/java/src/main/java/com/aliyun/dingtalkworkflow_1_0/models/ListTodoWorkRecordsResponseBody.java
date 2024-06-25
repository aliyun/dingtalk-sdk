// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListTodoWorkRecordsResponseBody extends TeaModel {
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
         * <strong>example:</strong>
         * <p>钉三多</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>入职员工姓名</p>
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
        @NameInMap("forms")
        public java.util.List<ListTodoWorkRecordsResponseBodyResultListForms> forms;

        /**
         * <strong>example:</strong>
         * <p>Siw2WNVZS4KiUt3tTmaNKg04*****809950</p>
         */
        @NameInMap("instanceId")
        public String instanceId;

        /**
         * <strong>example:</strong>
         * <p>1234567</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>xxx提交的入职审批</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
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
        @NameInMap("list")
        public java.util.List<ListTodoWorkRecordsResponseBodyResultList> list;

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
