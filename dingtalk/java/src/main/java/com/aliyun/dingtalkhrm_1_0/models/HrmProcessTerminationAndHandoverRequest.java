// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class HrmProcessTerminationAndHandoverRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("aflowHandOverUserId")
    public String aflowHandOverUserId;

    /**
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("dingPanHandoverUserId")
    public String dingPanHandoverUserId;

    /**
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("directSubordinatesHandoverUserId")
    public String directSubordinatesHandoverUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>aefadfadaewedad</p>
     */
    @NameInMap("dismissionMemo")
    public String dismissionMemo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("dismissionReason")
    public Integer dismissionReason;

    /**
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("docNoteHandoverUserId")
    public String docNoteHandoverUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1704074400000</p>
     */
    @NameInMap("lastWorkDate")
    public Long lastWorkDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>经理</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    /**
     * <strong>example:</strong>
     * <p>user123</p>
     */
    @NameInMap("permissionHandoverUserId")
    public String permissionHandoverUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2332</p>
     */
    @NameInMap("userId")
    public String userId;

    public static HrmProcessTerminationAndHandoverRequest build(java.util.Map<String, ?> map) throws Exception {
        HrmProcessTerminationAndHandoverRequest self = new HrmProcessTerminationAndHandoverRequest();
        return TeaModel.build(map, self);
    }

    public HrmProcessTerminationAndHandoverRequest setAflowHandOverUserId(String aflowHandOverUserId) {
        this.aflowHandOverUserId = aflowHandOverUserId;
        return this;
    }
    public String getAflowHandOverUserId() {
        return this.aflowHandOverUserId;
    }

    public HrmProcessTerminationAndHandoverRequest setDingPanHandoverUserId(String dingPanHandoverUserId) {
        this.dingPanHandoverUserId = dingPanHandoverUserId;
        return this;
    }
    public String getDingPanHandoverUserId() {
        return this.dingPanHandoverUserId;
    }

    public HrmProcessTerminationAndHandoverRequest setDirectSubordinatesHandoverUserId(String directSubordinatesHandoverUserId) {
        this.directSubordinatesHandoverUserId = directSubordinatesHandoverUserId;
        return this;
    }
    public String getDirectSubordinatesHandoverUserId() {
        return this.directSubordinatesHandoverUserId;
    }

    public HrmProcessTerminationAndHandoverRequest setDismissionMemo(String dismissionMemo) {
        this.dismissionMemo = dismissionMemo;
        return this;
    }
    public String getDismissionMemo() {
        return this.dismissionMemo;
    }

    public HrmProcessTerminationAndHandoverRequest setDismissionReason(Integer dismissionReason) {
        this.dismissionReason = dismissionReason;
        return this;
    }
    public Integer getDismissionReason() {
        return this.dismissionReason;
    }

    public HrmProcessTerminationAndHandoverRequest setDocNoteHandoverUserId(String docNoteHandoverUserId) {
        this.docNoteHandoverUserId = docNoteHandoverUserId;
        return this;
    }
    public String getDocNoteHandoverUserId() {
        return this.docNoteHandoverUserId;
    }

    public HrmProcessTerminationAndHandoverRequest setLastWorkDate(Long lastWorkDate) {
        this.lastWorkDate = lastWorkDate;
        return this;
    }
    public Long getLastWorkDate() {
        return this.lastWorkDate;
    }

    public HrmProcessTerminationAndHandoverRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

    public HrmProcessTerminationAndHandoverRequest setPermissionHandoverUserId(String permissionHandoverUserId) {
        this.permissionHandoverUserId = permissionHandoverUserId;
        return this;
    }
    public String getPermissionHandoverUserId() {
        return this.permissionHandoverUserId;
    }

    public HrmProcessTerminationAndHandoverRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
