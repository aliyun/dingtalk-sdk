// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryStudentClassRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>classIdxxx</p>
     */
    @NameInMap("classId")
    public String classId;

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

    @NameInMap("studentUserIds")
    public java.util.List<String> studentUserIds;

    public static QueryStudentClassRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryStudentClassRequest self = new QueryStudentClassRequest();
        return TeaModel.build(map, self);
    }

    public QueryStudentClassRequest setClassId(String classId) {
        this.classId = classId;
        return this;
    }
    public String getClassId() {
        return this.classId;
    }

    public QueryStudentClassRequest setClassType(Integer classType) {
        this.classType = classType;
        return this;
    }
    public Integer getClassType() {
        return this.classType;
    }

    public QueryStudentClassRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryStudentClassRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public QueryStudentClassRequest setStudentUserIds(java.util.List<String> studentUserIds) {
        this.studentUserIds = studentUserIds;
        return this;
    }
    public java.util.List<String> getStudentUserIds() {
        return this.studentUserIds;
    }

}
