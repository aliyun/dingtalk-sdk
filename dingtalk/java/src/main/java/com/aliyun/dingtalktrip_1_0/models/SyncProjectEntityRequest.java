// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncProjectEntityRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("channelCorpId")
    public String channelCorpId;

    @NameInMap("delAll")
    public Boolean delAll;

    @NameInMap("entityList")
    public java.util.List<SyncProjectEntityRequestEntityList> entityList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("projectId")
    public String projectId;

    /**
     * <p>This parameter is required.</p>
     */
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

    public SyncProjectEntityRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class SyncProjectEntityRequestEntityList extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("entityId")
        public String entityId;

        /**
         * <p>This parameter is required.</p>
         */
        @NameInMap("entityType")
        public String entityType;

        public static SyncProjectEntityRequestEntityList build(java.util.Map<String, ?> map) throws Exception {
            SyncProjectEntityRequestEntityList self = new SyncProjectEntityRequestEntityList();
            return TeaModel.build(map, self);
        }

        public SyncProjectEntityRequestEntityList setEntityId(String entityId) {
            this.entityId = entityId;
            return this;
        }
        public String getEntityId() {
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
