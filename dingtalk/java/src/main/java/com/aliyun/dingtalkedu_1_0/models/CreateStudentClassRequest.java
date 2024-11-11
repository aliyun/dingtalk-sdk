// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateStudentClassRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{&quot;key&quot;:&quot;value&quot;}</p>
     */
    @NameInMap("attributes")
    public String attributes;

    /**
     * <strong>example:</strong>
     * <p>classIdxxx</p>
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
     * <p>0</p>
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

    /**
     * <strong>example:</strong>
     * <p>小明</p>
     */
    @NameInMap("studentName")
    public String studentName;

    /**
     * <strong>example:</strong>
     * <p>staffxxx</p>
     */
    @NameInMap("studentUserId")
    public String studentUserId;

    public static CreateStudentClassRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateStudentClassRequest self = new CreateStudentClassRequest();
        return TeaModel.build(map, self);
    }

    public CreateStudentClassRequest setAttributes(String attributes) {
        this.attributes = attributes;
        return this;
    }
    public String getAttributes() {
        return this.attributes;
    }

    public CreateStudentClassRequest setClassId(String classId) {
        this.classId = classId;
        return this;
    }
    public String getClassId() {
        return this.classId;
    }

    public CreateStudentClassRequest setClassName(String className) {
        this.className = className;
        return this;
    }
    public String getClassName() {
        return this.className;
    }

    public CreateStudentClassRequest setClassType(Integer classType) {
        this.classType = classType;
        return this;
    }
    public Integer getClassType() {
        return this.classType;
    }

    public CreateStudentClassRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateStudentClassRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public CreateStudentClassRequest setStudentName(String studentName) {
        this.studentName = studentName;
        return this;
    }
    public String getStudentName() {
        return this.studentName;
    }

    public CreateStudentClassRequest setStudentUserId(String studentUserId) {
        this.studentUserId = studentUserId;
        return this;
    }
    public String getStudentUserId() {
        return this.studentUserId;
    }

}
