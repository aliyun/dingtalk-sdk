// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnfurlingRegisterCreatorResponseBody extends TeaModel {
    @NameInMap("data")
    public QueryUnfurlingRegisterCreatorResponseBodyData data;

    @NameInMap("success")
    public Boolean success;

    public static QueryUnfurlingRegisterCreatorResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUnfurlingRegisterCreatorResponseBody self = new QueryUnfurlingRegisterCreatorResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUnfurlingRegisterCreatorResponseBody setData(QueryUnfurlingRegisterCreatorResponseBodyData data) {
        this.data = data;
        return this;
    }
    public QueryUnfurlingRegisterCreatorResponseBodyData getData() {
        return this.data;
    }

    public QueryUnfurlingRegisterCreatorResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryUnfurlingRegisterCreatorResponseBodyData extends TeaModel {
        @NameInMap("appId")
        public String appId;

        @NameInMap("creatorUserId")
        public String creatorUserId;

        @NameInMap("id")
        public Long id;

        public static QueryUnfurlingRegisterCreatorResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            QueryUnfurlingRegisterCreatorResponseBodyData self = new QueryUnfurlingRegisterCreatorResponseBodyData();
            return TeaModel.build(map, self);
        }

        public QueryUnfurlingRegisterCreatorResponseBodyData setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public QueryUnfurlingRegisterCreatorResponseBodyData setCreatorUserId(String creatorUserId) {
            this.creatorUserId = creatorUserId;
            return this;
        }
        public String getCreatorUserId() {
            return this.creatorUserId;
        }

        public QueryUnfurlingRegisterCreatorResponseBodyData setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

    }

}
