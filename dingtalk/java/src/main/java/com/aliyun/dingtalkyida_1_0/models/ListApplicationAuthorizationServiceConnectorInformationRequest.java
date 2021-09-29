// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationAuthorizationServiceConnectorInformationRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("callerUid")
    public String callerUid;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    public static ListApplicationAuthorizationServiceConnectorInformationRequest build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationAuthorizationServiceConnectorInformationRequest self = new ListApplicationAuthorizationServiceConnectorInformationRequest();
        return TeaModel.build(map, self);
    }

    public ListApplicationAuthorizationServiceConnectorInformationRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public ListApplicationAuthorizationServiceConnectorInformationRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListApplicationAuthorizationServiceConnectorInformationRequest setCallerUid(String callerUid) {
        this.callerUid = callerUid;
        return this;
    }
    public String getCallerUid() {
        return this.callerUid;
    }

    public ListApplicationAuthorizationServiceConnectorInformationRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

}
