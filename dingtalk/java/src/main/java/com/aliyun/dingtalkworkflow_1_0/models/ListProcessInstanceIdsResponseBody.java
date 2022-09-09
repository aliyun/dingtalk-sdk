// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListProcessInstanceIdsResponseBody extends TeaModel {
    // 返回结果。
    @NameInMap("result")
    public ListProcessInstanceIdsResponseBodyResult result;

    // 接口请求是否成功。
    @NameInMap("success")
    public Boolean success;

    public static ListProcessInstanceIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListProcessInstanceIdsResponseBody self = new ListProcessInstanceIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListProcessInstanceIdsResponseBody setResult(ListProcessInstanceIdsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListProcessInstanceIdsResponseBodyResult getResult() {
        return this.result;
    }

    public ListProcessInstanceIdsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class ListProcessInstanceIdsResponseBodyResult extends TeaModel {
        // 审批实例ID列表。
        @NameInMap("list")
        public java.util.List<String> list;

        // 表示下次查询的游标，当返回结果没有该字段时表示没有更多数据了。
        @NameInMap("nextToken")
        public String nextToken;

        public static ListProcessInstanceIdsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListProcessInstanceIdsResponseBodyResult self = new ListProcessInstanceIdsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListProcessInstanceIdsResponseBodyResult setList(java.util.List<String> list) {
            this.list = list;
            return this;
        }
        public java.util.List<String> getList() {
            return this.list;
        }

        public ListProcessInstanceIdsResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
