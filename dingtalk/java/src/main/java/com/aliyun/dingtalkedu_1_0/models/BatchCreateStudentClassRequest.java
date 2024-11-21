// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchCreateStudentClassRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>classxxx</p>
     */
    @NameInMap("classId")
    public String classId;

    /**
     * <strong>example:</strong>
     * <p>一年级一班</p>
     */
    @NameInMap("className")
    public String className;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("classType")
    public Integer classType;

    /**
     * <strong>example:</strong>
     * <p>dingxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>ISV_XXX</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    @NameInMap("studentList")
    public java.util.List<BatchCreateStudentClassRequestStudentList> studentList;

    public static BatchCreateStudentClassRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateStudentClassRequest self = new BatchCreateStudentClassRequest();
        return TeaModel.build(map, self);
    }

    public BatchCreateStudentClassRequest setClassId(String classId) {
        this.classId = classId;
        return this;
    }
    public String getClassId() {
        return this.classId;
    }

    public BatchCreateStudentClassRequest setClassName(String className) {
        this.className = className;
        return this;
    }
    public String getClassName() {
        return this.className;
    }

    public BatchCreateStudentClassRequest setClassType(Integer classType) {
        this.classType = classType;
        return this;
    }
    public Integer getClassType() {
        return this.classType;
    }

    public BatchCreateStudentClassRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BatchCreateStudentClassRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public BatchCreateStudentClassRequest setStudentList(java.util.List<BatchCreateStudentClassRequestStudentList> studentList) {
        this.studentList = studentList;
        return this;
    }
    public java.util.List<BatchCreateStudentClassRequestStudentList> getStudentList() {
        return this.studentList;
    }

    public static class BatchCreateStudentClassRequestStudentList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>{&quot;&quot;}</p>
         */
        @NameInMap("attributes")
        public String attributes;

        /**
         * <strong>example:</strong>
         * <p>小明</p>
         */
        @NameInMap("studentName")
        public String studentName;

        /**
         * <strong>example:</strong>
         * <p>studentxxx</p>
         */
        @NameInMap("studentUserId")
        public String studentUserId;

        public static BatchCreateStudentClassRequestStudentList build(java.util.Map<String, ?> map) throws Exception {
            BatchCreateStudentClassRequestStudentList self = new BatchCreateStudentClassRequestStudentList();
            return TeaModel.build(map, self);
        }

        public BatchCreateStudentClassRequestStudentList setAttributes(String attributes) {
            this.attributes = attributes;
            return this;
        }
        public String getAttributes() {
            return this.attributes;
        }

        public BatchCreateStudentClassRequestStudentList setStudentName(String studentName) {
            this.studentName = studentName;
            return this;
        }
        public String getStudentName() {
            return this.studentName;
        }

        public BatchCreateStudentClassRequestStudentList setStudentUserId(String studentUserId) {
            this.studentUserId = studentUserId;
            return this;
        }
        public String getStudentUserId() {
            return this.studentUserId;
        }

    }

}
