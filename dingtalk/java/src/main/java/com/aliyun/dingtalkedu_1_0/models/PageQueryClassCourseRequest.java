// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PageQueryClassCourseRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>classId_xxx</p>
     */
    @NameInMap("classId")
    public String classId;

    /**
     * <strong>example:</strong>
     * <p>ding_xxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("endCourseDate")
    public Long endCourseDate;

    /**
     * <strong>example:</strong>
     * <p>ISV_XXX</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("startCourseDate")
    public Long startCourseDate;

    public static PageQueryClassCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        PageQueryClassCourseRequest self = new PageQueryClassCourseRequest();
        return TeaModel.build(map, self);
    }

    public PageQueryClassCourseRequest setClassId(String classId) {
        this.classId = classId;
        return this;
    }
    public String getClassId() {
        return this.classId;
    }

    public PageQueryClassCourseRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public PageQueryClassCourseRequest setEndCourseDate(Long endCourseDate) {
        this.endCourseDate = endCourseDate;
        return this;
    }
    public Long getEndCourseDate() {
        return this.endCourseDate;
    }

    public PageQueryClassCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public PageQueryClassCourseRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public PageQueryClassCourseRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public PageQueryClassCourseRequest setStartCourseDate(Long startCourseDate) {
        this.startCourseDate = startCourseDate;
        return this;
    }
    public Long getStartCourseDate() {
        return this.startCourseDate;
    }

}
