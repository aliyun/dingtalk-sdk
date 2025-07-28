// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryEduUnionAuthServiceRequest extends TeaModel {
    @NameInMap("ds")
    public String ds;

    public static QueryEduUnionAuthServiceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryEduUnionAuthServiceRequest self = new QueryEduUnionAuthServiceRequest();
        return TeaModel.build(map, self);
    }

    public QueryEduUnionAuthServiceRequest setDs(String ds) {
        this.ds = ds;
        return this;
    }
    public String getDs() {
        return this.ds;
    }

}
