// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncCostCenterEntityRequest extends TeaModel {
    @NameInMap("channelCorpId")
    public String channelCorpId;

    @NameInMap("costCenterId")
    public String costCenterId;

    @NameInMap("delAll")
    public Boolean delAll;

    @NameInMap("entityList")
    public java.util.List<SyncCostCenterEntityRequestEntityList> entityList;

    @NameInMap("userId")
    public String userId;

    public static SyncCostCenterEntityRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncCostCenterEntityRequest self = new SyncCostCenterEntityRequest();
        return TeaModel.build(map, self);
    }

    public SyncCostCenterEntityRequest setChannelCorpId(String channelCorpId) {
        this.channelCorpId = channelCorpId;
        return this;
    }
    public String getChannelCorpId() {
        return this.channelCorpId;
    }

    public SyncCostCenterEntityRequest setCostCenterId(String costCenterId) {
        this.costCenterId = costCenterId;
        return this;
    }
    public String getCostCenterId() {
        return this.costCenterId;
    }

    public SyncCostCenterEntityRequest setDelAll(Boolean delAll) {
        this.delAll = delAll;
        return this;
    }
    public Boolean getDelAll() {
        return this.delAll;
    }

    public SyncCostCenterEntityRequest setEntityList(java.util.List<SyncCostCenterEntityRequestEntityList> entityList) {
        this.entityList = entityList;
        return this;
    }
    public java.util.List<SyncCostCenterEntityRequestEntityList> getEntityList() {
        return this.entityList;
    }

    public SyncCostCenterEntityRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class SyncCostCenterEntityRequestEntityList extends TeaModel {
        @NameInMap("entityId")
        public String entityId;

        @NameInMap("entityType")
        public String entityType;

        public static SyncCostCenterEntityRequestEntityList build(java.util.Map<String, ?> map) throws Exception {
            SyncCostCenterEntityRequestEntityList self = new SyncCostCenterEntityRequestEntityList();
            return TeaModel.build(map, self);
        }

        public SyncCostCenterEntityRequestEntityList setEntityId(String entityId) {
            this.entityId = entityId;
            return this;
        }
        public String getEntityId() {
            return this.entityId;
        }

        public SyncCostCenterEntityRequestEntityList setEntityType(String entityType) {
            this.entityType = entityType;
            return this;
        }
        public String getEntityType() {
            return this.entityType;
        }

    }

}
