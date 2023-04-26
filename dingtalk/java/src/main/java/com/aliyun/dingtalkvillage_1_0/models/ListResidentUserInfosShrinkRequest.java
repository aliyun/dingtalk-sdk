// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentUserInfosShrinkRequest extends TeaModel {
    @NameInMap("subCorpId")
    public String subCorpId;

    @NameInMap("userIds")
    public String userIdsShrink;

    public static ListResidentUserInfosShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        ListResidentUserInfosShrinkRequest self = new ListResidentUserInfosShrinkRequest();
        return TeaModel.build(map, self);
    }

    public ListResidentUserInfosShrinkRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

    public ListResidentUserInfosShrinkRequest setUserIdsShrink(String userIdsShrink) {
        this.userIdsShrink = userIdsShrink;
        return this;
    }
    public String getUserIdsShrink() {
        return this.userIdsShrink;
    }

}
