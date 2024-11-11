// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class BatchInvalidCourseRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>class_xxx</p>
     */
    @NameInMap("classId")
    public String classId;

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
     * <p>courseId</p>
     */
    @NameInMap("isvCourseId")
    public String isvCourseId;

    @NameInMap("isvCourseIds")
    public java.util.List<String> isvCourseIds;

    public static BatchInvalidCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchInvalidCourseRequest self = new BatchInvalidCourseRequest();
        return TeaModel.build(map, self);
    }

    public BatchInvalidCourseRequest setClassId(String classId) {
        this.classId = classId;
        return this;
    }
    public String getClassId() {
        return this.classId;
    }

    public BatchInvalidCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public BatchInvalidCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public BatchInvalidCourseRequest setIsvCourseId(String isvCourseId) {
        this.isvCourseId = isvCourseId;
        return this;
    }
    public String getIsvCourseId() {
        return this.isvCourseId;
    }

    public BatchInvalidCourseRequest setIsvCourseIds(java.util.List<String> isvCourseIds) {
        this.isvCourseIds = isvCourseIds;
        return this;
    }
    public java.util.List<String> getIsvCourseIds() {
        return this.isvCourseIds;
    }

}
