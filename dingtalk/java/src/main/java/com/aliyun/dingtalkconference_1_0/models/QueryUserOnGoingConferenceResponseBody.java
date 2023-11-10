// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryUserOnGoingConferenceResponseBody extends TeaModel {
    @NameInMap("memberModelMap")
    public java.util.Map<String, MemberModelMapValue> memberModelMap;

    @NameInMap("onGoingConfIdList")
    public java.util.List<String> onGoingConfIdList;

    public static QueryUserOnGoingConferenceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUserOnGoingConferenceResponseBody self = new QueryUserOnGoingConferenceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUserOnGoingConferenceResponseBody setMemberModelMap(java.util.Map<String, MemberModelMapValue> memberModelMap) {
        this.memberModelMap = memberModelMap;
        return this;
    }
    public java.util.Map<String, MemberModelMapValue> getMemberModelMap() {
        return this.memberModelMap;
    }

    public QueryUserOnGoingConferenceResponseBody setOnGoingConfIdList(java.util.List<String> onGoingConfIdList) {
        this.onGoingConfIdList = onGoingConfIdList;
        return this;
    }
    public java.util.List<String> getOnGoingConfIdList() {
        return this.onGoingConfIdList;
    }

}
