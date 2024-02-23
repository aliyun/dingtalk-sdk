// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncProjectEntityRequest extends TeaModel {
    @NameInMap("channelCorpId")
    public String channelCorpId;

    @NameInMap("delAll")
    public Boolean delAll;

    @NameInMap("entityList")
    public java.util.List<SyncProjectEntityRequestEntityList> entityList;

    @NameInMap("projectId")
    public String projectId;

    @NameInMap("scope")
    public Integer scope;

    @NameInMap("userId")
    public String userId;

    public static SyncProjectEntityRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncProjectEntityRequest self = new SyncProjectEntityRequest();
        return TeaModel.build(map, self);
    }

    public SyncProjectEntityRequest setChannelCorpId(String channelCorpId) {
        this.channelCorpId = channelCorpId;
        return this;
    }
    public String getChannelCorpId() {
        return this.channelCorpId;
    }

    public SyncProjectEntityRequest setDelAll(Boolean delAll) {
        this.delAll = delAll;
        return this;
    }
    public Boolean getDelAll() {
        return this.delAll;
    }

    public SyncProjectEntityRequest setEntityList(java.util.List<SyncProjectEntityRequestEntityList> entityList) {
        this.entityList = entityList;
        return this;
    }
    public java.util.List<SyncProjectEntityRequestEntityList> getEntityList() {
        return this.entityList;
    }

    public SyncProjectEntityRequest setProjectId(String projectId) {
        this.projectId = projectId;
        return this;
    }
    public String getProjectId() {
        return this.projectId;
    }

    public SyncProjectEntityRequest setScope(Integer scope) {
        this.scope = scope;
        return this;
    }
    public Integer getScope() {
        return this.scope;
    }

    public SyncProjectEntityRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class SyncProjectEntityRequestEntityList extends TeaModel {
        @NameInMap("entityId")
        public java.util.List<String> entityId;

        @NameInMap("entityType")
        public String entityType;

        public static SyncProjectEntityRequestEntityList build(java.util.Map<String, ?> map) throws Exception {
            SyncProjectEntityRequestEntityList self = new SyncProjectEntityRequestEntityList();
            return TeaModel.build(map, self);
        }

        public SyncProjectEntityRequestEntityList setEntityId(java.util.List<String> entityId) {
            this.entityId = entityId;
            return this;
        }
        public java.util.List<String> getEntityId() {
            return this.entityId;
        }

        public SyncProjectEntityRequestEntityList setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

    }

}
