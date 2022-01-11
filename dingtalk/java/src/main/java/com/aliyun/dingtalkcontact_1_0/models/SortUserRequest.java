// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SortUserRequest extends TeaModel {
    // 0 根据姓名拼音升序排列 1 根据姓名拼音降序排列
    @NameInMap("sortType")
    public Integer sortType;

    // 用户id列表
    @NameInMap("userIdList")
    public java.util.List<String> userIdList;

    public static SortUserRequest build(java.util.Map<String, ?> map) throws Exception {
        SortUserRequest self = new SortUserRequest();
        return TeaModel.build(map, self);
    }

    public SortUserRequest setSortType(Integer sortType) {
        this.sortType = sortType;
        return this;
    }
    public Integer getSortType() {
        return this.sortType;
    }

    public SortUserRequest setUserIdList(java.util.List<String> userIdList) {
        this.userIdList = userIdList;
        return this;
    }
    public java.util.List<String> getUserIdList() {
        return this.userIdList;
    }

}
