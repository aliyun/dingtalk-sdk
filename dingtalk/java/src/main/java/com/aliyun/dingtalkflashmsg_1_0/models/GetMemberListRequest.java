// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class GetMemberListRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidjyErBTyw0FnIQQXXX2223==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>08474931138022787</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetMemberListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetMemberListRequest self = new GetMemberListRequest();
        return TeaModel.build(map, self);
    }

    public GetMemberListRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public GetMemberListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetMemberListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetMemberListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
