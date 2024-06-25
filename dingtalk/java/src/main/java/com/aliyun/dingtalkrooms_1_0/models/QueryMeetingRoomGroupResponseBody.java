// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomGroupResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>172</p>
     */
    @NameInMap("groupId")
    public Long groupId;

    /**
     * <strong>example:</strong>
     * <p>测试分组</p>
     */
    @NameInMap("groupName")
    public String groupName;

    /**
     * <strong>example:</strong>
     * <p>0</p>
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
