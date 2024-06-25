// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySchoolUserFaceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>从0开始</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>大于0小于200</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sn123</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1全量模式，2增量模式</p>
     */
    @NameInMap("type")
    public Integer type;

    public static QuerySchoolUserFaceRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySchoolUserFaceRequest self = new QuerySchoolUserFaceRequest();
        return TeaModel.build(map, self);
    }

    public QuerySchoolUserFaceRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QuerySchoolUserFaceRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QuerySchoolUserFaceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public QuerySchoolUserFaceRequest setType(Integer type) {
        this.type = type;
        return this;
    }
    public Integer getType() {
        return this.type;
    }

}
