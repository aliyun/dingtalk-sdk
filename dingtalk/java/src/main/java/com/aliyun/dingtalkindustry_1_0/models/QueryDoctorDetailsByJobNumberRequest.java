// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDoctorDetailsByJobNumberRequest extends TeaModel {
    // 按月安排
    @NameInMap("monthMark")
    public String monthMark;

    public static QueryDoctorDetailsByJobNumberRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDoctorDetailsByJobNumberRequest self = new QueryDoctorDetailsByJobNumberRequest();
        return TeaModel.build(map, self);
    }

    public QueryDoctorDetailsByJobNumberRequest setMonthMark(String monthMark) {
        this.monthMark = monthMark;
        return this;
    }
    public String getMonthMark() {
        return this.monthMark;
    }

}
