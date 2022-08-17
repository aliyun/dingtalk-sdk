// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListRelatedSpaceTeamsResponseBody extends TeaModel {
    @NameInMap("items")
    public java.util.List<TeamModel> items;

    public static ListRelatedSpaceTeamsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListRelatedSpaceTeamsResponseBody self = new ListRelatedSpaceTeamsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListRelatedSpaceTeamsResponseBody setItems(java.util.List<TeamModel> items) {
        this.items = items;
        return this;
    }
    public java.util.List<TeamModel> getItems() {
        return this.items;
    }

}
