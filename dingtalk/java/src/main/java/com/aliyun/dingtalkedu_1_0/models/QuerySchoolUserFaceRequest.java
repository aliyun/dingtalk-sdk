// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySchoolUserFaceRequest extends TeaModel {
    // 页码
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 设备序列号
    @NameInMap("sn")
    public String sn;

    // 类型
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
