// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class GetMemberListResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<String> result;

    public static GetMemberListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMemberListResponseBody self = new GetMemberListResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMemberListResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

}
