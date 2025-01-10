// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPeriodListRequest extends TeaModel {
    @NameInMap("body")
    public AgoalPeriodListRequestBody body;

    public static AgoalPeriodListRequest build(java.util.Map<String, ?> map) throws Exception {
        AgoalPeriodListRequest self = new AgoalPeriodListRequest();
        return TeaModel.build(map, self);
    }

    public AgoalPeriodListRequest setBody(AgoalPeriodListRequestBody body) {
        this.body = body;
        return this;
    }
    public AgoalPeriodListRequestBody getBody() {
        return this.body;
    }

    public static class AgoalPeriodListRequestBody extends TeaModel {
        @NameInMap("periodTypes")
        public java.util.List<String> periodTypes;

        public static AgoalPeriodListRequestBody build(java.util.Map<String, ?> map) throws Exception {
            AgoalPeriodListRequestBody self = new AgoalPeriodListRequestBody();
            return TeaModel.build(map, self);
        }

        public AgoalPeriodListRequestBody setPeriodTypes(java.util.List<String> periodTypes) {
            this.periodTypes = periodTypes;
            return this;
        }
        public java.util.List<String> getPeriodTypes() {
            return this.periodTypes;
        }

    }

}
