// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUserGroupAliasTitleResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryUserGroupAliasTitleResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryUserGroupAliasTitleResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserGroupAliasTitleResponseBody self = new QueryUserGroupAliasTitleResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserGroupAliasTitleResponseBody setResult(QueryUserGroupAliasTitleResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryUserGroupAliasTitleResponseBodyResult getResult() {
        return this.result;
    }

    public QueryUserGroupAliasTitleResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryUserGroupAliasTitleResponseBodyResult extends TeaModel {
        @NameInMap("title")
        public String title;

        public static QueryUserGroupAliasTitleResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryUserGroupAliasTitleResponseBodyResult self = new QueryUserGroupAliasTitleResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryUserGroupAliasTitleResponseBodyResult setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
