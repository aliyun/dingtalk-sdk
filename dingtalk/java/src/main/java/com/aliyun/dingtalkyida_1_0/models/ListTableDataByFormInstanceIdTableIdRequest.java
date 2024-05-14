// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListTableDataByFormInstanceIdTableIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tableFieldId")
    public String tableFieldId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ListTableDataByFormInstanceIdTableIdRequest build(java.util.Map<String, ?> map) throws Exception {
        ListTableDataByFormInstanceIdTableIdRequest self = new ListTableDataByFormInstanceIdTableIdRequest();
        return TeaModel.build(map, self);
    }

    public ListTableDataByFormInstanceIdTableIdRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public ListTableDataByFormInstanceIdTableIdRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public ListTableDataByFormInstanceIdTableIdRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListTableDataByFormInstanceIdTableIdRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListTableDataByFormInstanceIdTableIdRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public ListTableDataByFormInstanceIdTableIdRequest setTableFieldId(String tableFieldId) {
        this.tableFieldId = tableFieldId;
        return this;
    }
    public String getTableFieldId() {
        return this.tableFieldId;
    }

    public ListTableDataByFormInstanceIdTableIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
