// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomGroupResponseBody extends TeaModel {
    /**
     * <p>分组id</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <p>分组名称</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <p>父分组id</p>
     */
    @NameInMap("parentId")
    public Long parentId;

    public static QueryMeetingRoomGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomGroupResponseBody self = new QueryMeetingRoomGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomGroupResponseBody setGroupId(Long groupId) {
        this.groupId = groupId;
        return this;
    }
    public Long getGroupId() {
        return this.groupId;
    }

    public QueryMeetingRoomGroupResponseBody setGroupName(String groupName) {
        this.groupName = groupName;
        return this;
    }
    public String getGroupName() {
        return this.groupName;
    }

    public QueryMeetingRoomGroupResponseBody setParentId(Long parentId) {
        this.parentId = parentId;
        return this;
    }
    public Long getParentId() {
        return this.parentId;
    }

}
