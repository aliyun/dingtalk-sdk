// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetRemoteClassCourseRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operator")
    public String operator;

    public static GetRemoteClassCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRemoteClassCourseRequest self = new GetRemoteClassCourseRequest();
        return TeaModel.build(map, self);
    }

    public GetRemoteClassCourseRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

}
