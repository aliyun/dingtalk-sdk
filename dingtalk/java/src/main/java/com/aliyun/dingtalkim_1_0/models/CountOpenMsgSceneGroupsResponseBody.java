// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CountOpenMsgSceneGroupsResponseBody extends TeaModel {
    @NameInMap("result")
    public CountOpenMsgSceneGroupsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static CountOpenMsgSceneGroupsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CountOpenMsgSceneGroupsResponseBody self = new CountOpenMsgSceneGroupsResponseBody();
        return TeaModel.build(map, self);
    }

    public CountOpenMsgSceneGroupsResponseBody setResult(CountOpenMsgSceneGroupsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public CountOpenMsgSceneGroupsResponseBodyResult getResult() {
        return this.result;
    }

    public CountOpenMsgSceneGroupsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class CountOpenMsgSceneGroupsResponseBodyResult extends TeaModel {
        @NameInMap("count")
        public Long count;

        public static CountOpenMsgSceneGroupsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            CountOpenMsgSceneGroupsResponseBodyResult self = new CountOpenMsgSceneGroupsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public CountOpenMsgSceneGroupsResponseBodyResult setCount(Long count) {
            this.count = count;
            return this;
        }
        public Long getCount() {
            return this.count;
        }

    }

}
