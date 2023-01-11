// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateInterconnectionResponseBody extends TeaModel {
    /**
     * <p>创建失败的钉外钉内关系列表。</p>
     */
    @NameInMap("results")
    public java.util.List<CreateInterconnectionResponseBodyResults> results;

    public static CreateInterconnectionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateInterconnectionResponseBody self = new CreateInterconnectionResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateInterconnectionResponseBody setResults(java.util.List<CreateInterconnectionResponseBodyResults> results) {
        this.results = results;
        return this;
    }
    public java.util.List<CreateInterconnectionResponseBodyResults> getResults() {
        return this.results;
    }

    public static class CreateInterconnectionResponseBodyResults extends TeaModel {
        /**
         * <p>钉外用户在业务系统内的唯一标识。</p>
         */
        @NameInMap("appUserId")
        public String appUserId;

        /**
         * <p>钉内用户userId。</p>
         */
        @NameInMap("userId")
        public String userId;

        public static CreateInterconnectionResponseBodyResults build(java.util.Map<String, ?> map) throws Exception {
            CreateInterconnectionResponseBodyResults self = new CreateInterconnectionResponseBodyResults();
            return TeaModel.build(map, self);
        }

        public CreateInterconnectionResponseBodyResults setAppUserId(String appUserId) {
            this.appUserId = appUserId;
            return this;
        }
        public String getAppUserId() {
            return this.appUserId;
        }

        public CreateInterconnectionResponseBodyResults setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
