// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CreateClueTempRequest extends TeaModel {
    @NameInMap("address")
    public String address;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("contactName")
    public String contactName;

    @NameInMap("deptId")
    public Long deptId;

    /**
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("phoneNum")
    public String phoneNum;

    @NameInMap("position")
    public String position;

    @NameInMap("productCode")
    public String productCode;

    @NameInMap("salesId")
    public Long salesId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("source")
    public String source;

    public static CreateClueTempRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateClueTempRequest self = new CreateClueTempRequest();
        return TeaModel.build(map, self);
    }

    public CreateClueTempRequest setAddress(String address) {
        this.address = address;
        return this;
    }
    public String getAddress() {
        return this.address;
    }

    public CreateClueTempRequest setContactName(String contactName) {
        this.contactName = contactName;
        return this;
    }
    public String getContactName() {
        return this.contactName;
    }

    public CreateClueTempRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CreateClueTempRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public CreateClueTempRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CreateClueTempRequest setPhoneNum(String phoneNum) {
        this.phoneNum = phoneNum;
        return this;
    }
    public String getPhoneNum() {
        return this.phoneNum;
    }

    public CreateClueTempRequest setPosition(String position) {
        this.position = position;
        return this;
    }
    public String getPosition() {
        return this.position;
    }

    public CreateClueTempRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public CreateClueTempRequest setSalesId(Long salesId) {
        this.salesId = salesId;
        return this;
    }
    public Long getSalesId() {
        return this.salesId;
    }

    public CreateClueTempRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

}
