// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateTransferRecordRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>{&quot;&quot;}</p>
     */
    @NameInMap("attributes")
    public String attributes;

    /**
     * <strong>example:</strong>
     * <p>classIdx</p>
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
     * <p>record</p>
     */
    @NameInMap("isvRecordId")
    public String isvRecordId;

    /**
     * <strong>example:</strong>
     * <p>courseCode</p>
     */
    @NameInMap("srcCourseCode")
    public String srcCourseCode;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("srcCourseDate")
    public Long srcCourseDate;

    /**
     * <strong>example:</strong>
     * <p>语文</p>
     */
    @NameInMap("srcCourseName")
    public String srcCourseName;

    /**
     * <strong>example:</strong>
     * <p>courseId</p>
     */
    @NameInMap("srcIsvCourseId")
    public String srcIsvCourseId;

    /**
     * <strong>example:</strong>
     * <p>第一节</p>
     */
    @NameInMap("srcTimeslotName")
    public String srcTimeslotName;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("srcTimeslotNum")
    public Integer srcTimeslotNum;

    /**
     * <strong>example:</strong>
     * <p>courseCode</p>
     */
    @NameInMap("tarCourseCode")
    public String tarCourseCode;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("tarCourseDate")
    public Long tarCourseDate;

    /**
     * <strong>example:</strong>
     * <p>语文</p>
     */
    @NameInMap("tarCourseName")
    public String tarCourseName;

    /**
     * <strong>example:</strong>
     * <p>courseId</p>
     */
    @NameInMap("tarIsvCourseId")
    public String tarIsvCourseId;

    /**
     * <strong>example:</strong>
     * <p>第二节</p>
     */
    @NameInMap("tarTimeslotName")
    public String tarTimeslotName;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("tarTimeslotNum")
    public Integer tarTimeslotNum;

    public static CreateTransferRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTransferRecordRequest self = new CreateTransferRecordRequest();
        return TeaModel.build(map, self);
    }

    public CreateTransferRecordRequest setAttributes(String attributes) {
        this.attributes = attributes;
        return this;
    }
    public String getAttributes() {
        return this.attributes;
    }

    public CreateTransferRecordRequest setClassId(String classId) {
        this.classId = classId;
        return this;
    }
    public String getClassId() {
        return this.classId;
    }

    public CreateTransferRecordRequest setClassName(String className) {
        this.className = className;
        return this;
    }
    public String getClassName() {
        return this.className;
    }

    public CreateTransferRecordRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateTransferRecordRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public CreateTransferRecordRequest setIsvRecordId(String isvRecordId) {
        this.isvRecordId = isvRecordId;
        return this;
    }
    public String getIsvRecordId() {
        return this.isvRecordId;
    }

    public CreateTransferRecordRequest setSrcCourseCode(String srcCourseCode) {
        this.srcCourseCode = srcCourseCode;
        return this;
    }
    public String getSrcCourseCode() {
        return this.srcCourseCode;
    }

    public CreateTransferRecordRequest setSrcCourseDate(Long srcCourseDate) {
        this.srcCourseDate = srcCourseDate;
        return this;
    }
    public Long getSrcCourseDate() {
        return this.srcCourseDate;
    }

    public CreateTransferRecordRequest setSrcCourseName(String srcCourseName) {
        this.srcCourseName = srcCourseName;
        return this;
    }
    public String getSrcCourseName() {
        return this.srcCourseName;
    }

    public CreateTransferRecordRequest setSrcIsvCourseId(String srcIsvCourseId) {
        this.srcIsvCourseId = srcIsvCourseId;
        return this;
    }
    public String getSrcIsvCourseId() {
        return this.srcIsvCourseId;
    }

    public CreateTransferRecordRequest setSrcTimeslotName(String srcTimeslotName) {
        this.srcTimeslotName = srcTimeslotName;
        return this;
    }
    public String getSrcTimeslotName() {
        return this.srcTimeslotName;
    }

    public CreateTransferRecordRequest setSrcTimeslotNum(Integer srcTimeslotNum) {
        this.srcTimeslotNum = srcTimeslotNum;
        return this;
    }
    public Integer getSrcTimeslotNum() {
        return this.srcTimeslotNum;
    }

    public CreateTransferRecordRequest setTarCourseCode(String tarCourseCode) {
        this.tarCourseCode = tarCourseCode;
        return this;
    }
    public String getTarCourseCode() {
        return this.tarCourseCode;
    }

    public CreateTransferRecordRequest setTarCourseDate(Long tarCourseDate) {
        this.tarCourseDate = tarCourseDate;
        return this;
    }
    public Long getTarCourseDate() {
        return this.tarCourseDate;
    }

    public CreateTransferRecordRequest setTarCourseName(String tarCourseName) {
        this.tarCourseName = tarCourseName;
        return this;
    }
    public String getTarCourseName() {
        return this.tarCourseName;
    }

    public CreateTransferRecordRequest setTarIsvCourseId(String tarIsvCourseId) {
        this.tarIsvCourseId = tarIsvCourseId;
        return this;
    }
    public String getTarIsvCourseId() {
        return this.tarIsvCourseId;
    }

    public CreateTransferRecordRequest setTarTimeslotName(String tarTimeslotName) {
        this.tarTimeslotName = tarTimeslotName;
        return this;
    }
    public String getTarTimeslotName() {
        return this.tarTimeslotName;
    }

    public CreateTransferRecordRequest setTarTimeslotNum(Integer tarTimeslotNum) {
        this.tarTimeslotNum = tarTimeslotNum;
        return this;
    }
    public Integer getTarTimeslotNum() {
        return this.tarTimeslotNum;
    }

}
