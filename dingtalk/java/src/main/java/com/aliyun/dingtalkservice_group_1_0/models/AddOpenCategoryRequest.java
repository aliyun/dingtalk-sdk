// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddOpenCategoryRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>5555</p>
     */
    @NameInMap("libraryId")
    public Long libraryId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Jxi12wo3qxoa</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("parentId")
    public Long parentId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>测试类目</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0159003451667222</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>钉三多</p>
     */
    @NameInMap("userName")
    public String userName;

    public static AddOpenCategoryRequest build(java.util.Map<String, ?> map) throws Exception {
        AddOpenCategoryRequest self = new AddOpenCategoryRequest();
        return TeaModel.build(map, self);
    }

    public AddOpenCategoryRequest setLibraryId(Long libraryId) {
        this.libraryId = libraryId;
        return this;
    }
    public Long getLibraryId() {
        return this.libraryId;
    }

    public AddOpenCategoryRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddOpenCategoryRequest setParentId(Long parentId) {
        this.parentId = parentId;
        return this;
    }
    public Long getParentId() {
        return this.parentId;
    }

    public AddOpenCategoryRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public AddOpenCategoryRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public AddOpenCategoryRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

}
