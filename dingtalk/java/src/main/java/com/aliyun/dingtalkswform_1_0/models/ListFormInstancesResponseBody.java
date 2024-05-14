// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormInstancesResponseBody extends TeaModel {
    @NameInMap("result")
    public ListFormInstancesResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static ListFormInstancesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListFormInstancesResponseBody self = new ListFormInstancesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListFormInstancesResponseBody setResult(ListFormInstancesResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListFormInstancesResponseBodyResult getResult() {
        return this.result;
    }

    public ListFormInstancesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListFormInstancesResponseBodyResultListForms extends TeaModel {
        @NameInMap("key")
        public String key;

        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static ListFormInstancesResponseBodyResultListForms build(java.util.Map<String, ?> map) throws Exception {
            ListFormInstancesResponseBodyResultListForms self = new ListFormInstancesResponseBodyResultListForms();
            return TeaModel.build(map, self);
        }

        public ListFormInstancesResponseBodyResultListForms setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

        public ListFormInstancesResponseBodyResultListForms setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public ListFormInstancesResponseBodyResultListForms setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class ListFormInstancesResponseBodyResultList extends TeaModel {
        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("formCode")
        public String formCode;

        @NameInMap("formInstanceId")
        public String formInstanceId;

        @NameInMap("forms")
        public java.util.List<ListFormInstancesResponseBodyResultListForms> forms;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        @NameInMap("studentClassId")
        public String studentClassId;

        @NameInMap("studentClassName")
        public String studentClassName;

        @NameInMap("studentName")
        public String studentName;

        @NameInMap("studentUserId")
        public String studentUserId;

        @NameInMap("submitterUserId")
        public String submitterUserId;

        @NameInMap("submitterUserName")
        public String submitterUserName;

        @NameInMap("title")
        public String title;

        public static ListFormInstancesResponseBodyResultList build(java.util.Map<String, ?> map) throws Exception {
            ListFormInstancesResponseBodyResultList self = new ListFormInstancesResponseBodyResultList();
            return TeaModel.build(map, self);
        }

        public ListFormInstancesResponseBodyResultList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListFormInstancesResponseBodyResultList setFormCode(String formCode) {
            this.formCode = formCode;
            return this;
        }
        public String getFormCode() {
            return this.formCode;
        }

        public ListFormInstancesResponseBodyResultList setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public ListFormInstancesResponseBodyResultList setForms(java.util.List<ListFormInstancesResponseBodyResultListForms> forms) {
            this.forms = forms;
            return this;
        }
        public java.util.List<ListFormInstancesResponseBodyResultListForms> getForms() {
            return this.forms;
        }

        public ListFormInstancesResponseBodyResultList setModifyTime(String modifyTime) {
            this.modifyTime = modifyTime;
            return this;
        }
        public String getModifyTime() {
            return this.modifyTime;
        }

        public ListFormInstancesResponseBodyResultList setStudentClassId(String studentClassId) {
            this.studentClassId = studentClassId;
            return this;
        }
        public String getStudentClassId() {
            return this.studentClassId;
        }

        public ListFormInstancesResponseBodyResultList setStudentClassName(String studentClassName) {
            this.studentClassName = studentClassName;
            return this;
        }
        public String getStudentClassName() {
            return this.studentClassName;
        }

        public ListFormInstancesResponseBodyResultList setStudentName(String studentName) {
            this.studentName = studentName;
            return this;
        }
        public String getStudentName() {
            return this.studentName;
        }

        public ListFormInstancesResponseBodyResultList setStudentUserId(String studentUserId) {
            this.studentUserId = studentUserId;
            return this;
        }
        public String getStudentUserId() {
            return this.studentUserId;
        }

        public ListFormInstancesResponseBodyResultList setSubmitterUserId(String submitterUserId) {
            this.submitterUserId = submitterUserId;
            return this;
        }
        public String getSubmitterUserId() {
            return this.submitterUserId;
        }

        public ListFormInstancesResponseBodyResultList setSubmitterUserName(String submitterUserName) {
            this.submitterUserName = submitterUserName;
            return this;
        }
        public String getSubmitterUserName() {
            return this.submitterUserName;
        }

        public ListFormInstancesResponseBodyResultList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class ListFormInstancesResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<ListFormInstancesResponseBodyResultList> list;

        @NameInMap("nextToken")
        public Long nextToken;

        public static ListFormInstancesResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListFormInstancesResponseBodyResult self = new ListFormInstancesResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListFormInstancesResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public ListFormInstancesResponseBodyResult setList(java.util.List<ListFormInstancesResponseBodyResultList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<ListFormInstancesResponseBodyResultList> getList() {
            return this.list;
        }

        public ListFormInstancesResponseBodyResult setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

    }

}
