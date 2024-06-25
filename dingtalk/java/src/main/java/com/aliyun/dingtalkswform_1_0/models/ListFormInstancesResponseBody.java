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
        /**
         * <strong>example:</strong>
         * <p>TextareaField_KGAW58AQ</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <strong>example:</strong>
         * <p>你希望的主题</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <strong>example:</strong>
         * <p>操作演示</p>
         */
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
         * 
         * <strong>example:</strong>
         * <p>2022-07-27T18:53Z</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>PROC-E5BD2166-B6F4-xxxx</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <strong>example:</strong>
         * <p>11125769-fxxxx</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        @NameInMap("forms")
        public java.util.List<ListFormInstancesResponseBodyResultListForms> forms;

        /**
         * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
         * 
         * <strong>example:</strong>
         * <p>2022-07-27T18:53Z</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("studentClassId")
        public String studentClassId;

        /**
         * <strong>example:</strong>
         * <p>三年二班</p>
         */
        @NameInMap("studentClassName")
        public String studentClassName;

        /**
         * <strong>example:</strong>
         * <p>钉三多</p>
         */
        @NameInMap("studentName")
        public String studentName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("studentUserId")
        public String studentUserId;

        /**
         * <strong>example:</strong>
         * <p>user123</p>
         */
        @NameInMap("submitterUserId")
        public String submitterUserId;

        /**
         * <strong>example:</strong>
         * <p>钉三多</p>
         */
        @NameInMap("submitterUserName")
        public String submitterUserName;

        /**
         * <strong>example:</strong>
         * <p>智能填表测试</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<ListFormInstancesResponseBodyResultList> list;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
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
