// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class DigitalStoreCardRecordRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1696917858123</p>
     */
    @NameInMap("beginTime")
    public Long beginTime;

    /**
     * <strong>example:</strong>
     * <p>1696918858123</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("ids")
    public java.util.List<Long> ids;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>场景卡片名称</p>
     */
    @NameInMap("sceneCardName")
    public String sceneCardName;

    public static DigitalStoreCardRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        DigitalStoreCardRecordRequest self = new DigitalStoreCardRecordRequest();
        return TeaModel.build(map, self);
    }

    public DigitalStoreCardRecordRequest setBeginTime(Long beginTime) {
        this.beginTime = beginTime;
        return this;
    }
    public Long getBeginTime() {
        return this.beginTime;
    }

    public DigitalStoreCardRecordRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public DigitalStoreCardRecordRequest setIds(java.util.List<Long> ids) {
        this.ids = ids;
        return this;
    }
    public java.util.List<Long> getIds() {
        return this.ids;
    }

    public DigitalStoreCardRecordRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public DigitalStoreCardRecordRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public DigitalStoreCardRecordRequest setSceneCardName(String sceneCardName) {
        this.sceneCardName = sceneCardName;
        return this;
    }
    public String getSceneCardName() {
        return this.sceneCardName;
    }

}
