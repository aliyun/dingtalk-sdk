// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetCollegeAlumniUserInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operator")
    public String operator;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetCollegeAlumniUserInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCollegeAlumniUserInfoRequest self = new GetCollegeAlumniUserInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetCollegeAlumniUserInfoRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public GetCollegeAlumniUserInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
