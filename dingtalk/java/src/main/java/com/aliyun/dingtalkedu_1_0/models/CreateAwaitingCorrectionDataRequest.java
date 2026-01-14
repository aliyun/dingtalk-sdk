// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateAwaitingCorrectionDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://example.com/files/corrected_math_hw_T250401-001.pdf">https://example.com/files/corrected_math_hw_T250401-001.pdf</a></p>
     */
    @NameInMap("allAssignmentPdfUrl")
    public String allAssignmentPdfUrl;

    /**
     * <strong>example:</strong>
     * <p>501</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("className")
    public String className;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding8196cd122f5cc6abecb851</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;paperSize&quot;:&quot;A4&quot;,&quot;duplex&quot;:false,&quot;color&quot;:true}</p>
     */
    @NameInMap("printInfo")
    public String printInfo;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>PRINTER1</p>
     */
    @NameInMap("printerCode")
    public String printerCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>数学</p>
     */
    @NameInMap("subjectName")
    public String subjectName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DING_GRADING_1</p>
     */
    @NameInMap("taskCode")
    public String taskCode;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>80</p>
     */
    @NameInMap("totalPages")
    public Integer totalPages;

    public static CreateAwaitingCorrectionDataRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateAwaitingCorrectionDataRequest self = new CreateAwaitingCorrectionDataRequest();
        return TeaModel.build(map, self);
    }

    public CreateAwaitingCorrectionDataRequest setAllAssignmentPdfUrl(String allAssignmentPdfUrl) {
        this.allAssignmentPdfUrl = allAssignmentPdfUrl;
        return this;
    }
    public String getAllAssignmentPdfUrl() {
        return this.allAssignmentPdfUrl;
    }

    public CreateAwaitingCorrectionDataRequest setClassName(String className) {
        this.className = className;
        return this;
    }
    public String getClassName() {
        return this.className;
    }

    public CreateAwaitingCorrectionDataRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateAwaitingCorrectionDataRequest setPrintInfo(String printInfo) {
        this.printInfo = printInfo;
        return this;
    }
    public String getPrintInfo() {
        return this.printInfo;
    }

    public CreateAwaitingCorrectionDataRequest setPrinterCode(String printerCode) {
        this.printerCode = printerCode;
        return this;
    }
    public String getPrinterCode() {
        return this.printerCode;
    }

    public CreateAwaitingCorrectionDataRequest setSubjectName(String subjectName) {
        this.subjectName = subjectName;
        return this;
    }
    public String getSubjectName() {
        return this.subjectName;
    }

    public CreateAwaitingCorrectionDataRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

    public CreateAwaitingCorrectionDataRequest setTotalPages(Integer totalPages) {
        this.totalPages = totalPages;
        return this;
    }
    public Integer getTotalPages() {
        return this.totalPages;
    }

}
