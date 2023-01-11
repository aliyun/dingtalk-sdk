// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkswform_1_0.models;

import com.aliyun.tea.*;

public class ListFormInstancesResponseBody extends TeaModel {
    /**
     * <p>返回结果对象。</p>
     */
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
         * <p>表单控件key。</p>
         */
        @NameInMap("key")
        public String key;

        /**
         * <p>表单主题。  当label字段为空或不存在时，忽略这个label和value。</p>
         */
        @NameInMap("label")
        public String label;

        /**
         * <p>表单的值。</p>
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
         * <p>创建时间。iso8601格式。</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>填表code，用此code可调接口获取填表列表。</p>
         */
        @NameInMap("formCode")
        public String formCode;

        /**
         * <p>实例ID。</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        /**
         * <p>表单内容列表。</p>
         */
        @NameInMap("forms")
        public java.util.List<ListFormInstancesResponseBodyResultListForms> forms;

        /**
         * <p>更新时间。iso8601格式。</p>
         */
        @NameInMap("modifyTime")
        public String modifyTime;

        /**
         * <p>学生班级ID。</p>
         */
        @NameInMap("studentClassId")
        public String studentClassId;

        /**
         * <p>学生班级名称。</p>
         */
        @NameInMap("studentClassName")
        public String studentClassName;

        /**
         * <p>学生名称。</p>
         */
        @NameInMap("studentName")
        public String studentName;

        /**
         * <p>学生ID。</p>
         */
        @NameInMap("studentUserId")
        public String studentUserId;

        /**
         * <p>提交人的userid。</p>
         */
        @NameInMap("submitterUserId")
        public String submitterUserId;

        /**
         * <p>提交人姓名。</p>
         */
        @NameInMap("submitterUserName")
        public String submitterUserName;

        /**
         * <p>填表名称。</p>
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
         * <p>是否还有下一页数据。</p>
         */
        @NameInMap("hasMore")
        public Boolean hasMore;

        /**
         * <p>填表实例列表。</p>
         */
        @NameInMap("list")
        public java.util.List<ListFormInstancesResponseBodyResultList> list;

        /**
         * <p>下一次分页offset的值。</p>
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
