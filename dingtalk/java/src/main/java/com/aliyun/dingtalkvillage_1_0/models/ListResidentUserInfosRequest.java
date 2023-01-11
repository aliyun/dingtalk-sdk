// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListResidentUserInfosRequest extends TeaModel {
    /**
     * <p>下属组织的组织ID，比如下属镇、村的corpId</p>
     */
    @NameInMap("subCorpId")
    public String subCorpId;

    /**
     * <p>用户id列表</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static ListResidentUserInfosRequest build(java.util.Map<String, ?> map) throws Exception {
        ListResidentUserInfosRequest self = new ListResidentUserInfosRequest();
        return TeaModel.build(map, self);
    }

    public ListResidentUserInfosRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

    public ListResidentUserInfosRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
