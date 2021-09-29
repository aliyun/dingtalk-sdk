// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListTableDataByFormInstanceIdTableIdRequest extends TeaModel {
    // 表单ID
    @NameInMap("formUuid")
    public String formUuid;

    // 需要查找的子表单组件的唯一标识
    @NameInMap("tableFieldId")
    public String tableFieldId;

    // 当前页
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 每页记录数
    @NameInMap("pageSize")
    public Integer pageSize;

    // 应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉的userId
    @NameInMap("userId")
    public String userId;

    public static ListTableDataByFormInstanceIdTableIdRequest build(java.util.Map<String, ?> map) throws Exception {
        ListTableDataByFormInstanceIdTableIdRequest self = new ListTableDataByFormInstanceIdTableIdRequest();
        return TeaModel.build(map, self);
    }

    public ListTableDataByFormInstanceIdTableIdRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public ListTableDataByFormInstanceIdTableIdRequest setTableFieldId(String tableFieldId) {
        this.tableFieldId = tableFieldId;
        return this;
    }
    public String getTableFieldId() {
        return this.tableFieldId;
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

    public ListTableDataByFormInstanceIdTableIdRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
