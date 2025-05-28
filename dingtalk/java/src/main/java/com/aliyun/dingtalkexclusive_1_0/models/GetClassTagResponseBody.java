// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetClassTagResponseBody extends TeaModel {
    @NameInMap("creatorName")
    public String creatorName;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("dataType")
    public Integer dataType;

    /**
     * <strong>example:</strong>
     * <p>描述信息</p>
     */
    @NameInMap("description")
    public String description;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("innerDownload")
    public String innerDownload;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("innerTransfer")
    public String innerTransfer;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("modifierName")
    public String modifierName;

    /**
     * <strong>example:</strong>
     * <p>标签名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("outOp")
    public String outOp;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("rank")
    public Integer rank;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <strong>example:</strong>
     * <p>1735023822867</p>
     */
    @NameInMap("updateTime")
    public Long updateTime;

    public static GetClassTagResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetClassTagResponseBody self = new GetClassTagResponseBody();
        return TeaModel.build(map, self);
    }

    public GetClassTagResponseBody setCreatorName(String creatorName) {
        this.creatorName = creatorName;
        return this;
    }
    public String getCreatorName() {
        return this.creatorName;
    }

    public GetClassTagResponseBody setDataType(Integer dataType) {
        this.dataType = dataType;
        return this;
    }
    public Integer getDataType() {
        return this.dataType;
    }

    public GetClassTagResponseBody setDescription(String description) {
        this.description = description;
        return this;
    }
    public String getDescription() {
        return this.description;
    }

    public GetClassTagResponseBody setInnerDownload(String innerDownload) {
        this.innerDownload = innerDownload;
        return this;
    }
    public String getInnerDownload() {
        return this.innerDownload;
    }

    public GetClassTagResponseBody setInnerTransfer(String innerTransfer) {
        this.innerTransfer = innerTransfer;
        return this;
    }
    public String getInnerTransfer() {
        return this.innerTransfer;
    }

    public GetClassTagResponseBody setModifierName(String modifierName) {
        this.modifierName = modifierName;
        return this;
    }
    public String getModifierName() {
        return this.modifierName;
    }

    public GetClassTagResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetClassTagResponseBody setOutOp(String outOp) {
        this.outOp = outOp;
        return this;
    }
    public String getOutOp() {
        return this.outOp;
    }

    public GetClassTagResponseBody setRank(Integer rank) {
        this.rank = rank;
        return this;
    }
    public Integer getRank() {
        return this.rank;
    }

    public GetClassTagResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public GetClassTagResponseBody setUpdateTime(Long updateTime) {
        this.updateTime = updateTime;
        return this;
    }
    public Long getUpdateTime() {
        return this.updateTime;
    }

}
