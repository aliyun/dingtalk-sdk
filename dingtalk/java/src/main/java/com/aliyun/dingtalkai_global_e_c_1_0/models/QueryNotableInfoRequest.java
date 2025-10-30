// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class QueryNotableInfoRequest extends TeaModel {
    @NameInMap("sceneCode")
    public String sceneCode;

    public static QueryNotableInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryNotableInfoRequest self = new QueryNotableInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryNotableInfoRequest setSceneCode(String sceneCode) {
        this.sceneCode = sceneCode;
        return this;
    }
    public String getSceneCode() {
        return this.sceneCode;
    }

}
