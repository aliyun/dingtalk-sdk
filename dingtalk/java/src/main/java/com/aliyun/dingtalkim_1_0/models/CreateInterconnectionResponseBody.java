// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateInterconnectionResponseBody extends TeaModel {
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
        @NameInMap("appUserId")
        public String appUserId;

        @NameInMap("message")
        public String message;

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

        public CreateInterconnectionResponseBodyResults setMessage(String message) {
            this.message = message;
            return this;
        }
        public String getMessage() {
            return this.message;
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
