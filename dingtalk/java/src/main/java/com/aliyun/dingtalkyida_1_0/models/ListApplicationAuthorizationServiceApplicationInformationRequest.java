// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ListApplicationAuthorizationServiceApplicationInformationRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("pageSize")
    public Integer pageSize;

    @NameInMap("callerUnionId")
    public String callerUnionId;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    public static ListApplicationAuthorizationServiceApplicationInformationRequest build(java.util.Map<String, ?> map) throws Exception {
        ListApplicationAuthorizationServiceApplicationInformationRequest self = new ListApplicationAuthorizationServiceApplicationInformationRequest();
        return TeaModel.build(map, self);
    }

    public ListApplicationAuthorizationServiceApplicationInformationRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public ListApplicationAuthorizationServiceApplicationInformationRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public ListApplicationAuthorizationServiceApplicationInformationRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

    public ListApplicationAuthorizationServiceApplicationInformationRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

}
