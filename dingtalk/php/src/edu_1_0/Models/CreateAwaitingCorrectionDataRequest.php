<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateAwaitingCorrectionDataRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example https://example.com/files/corrected_math_hw_T250401-001.pdf
     *
     * @var string
     */
    public $allAssignmentPdfUrl;

    /**
     * @example 501
     *
     * @var string
     */
    public $className;

    /**
     * @description This parameter is required.
     *
     * @example ding8196cd122f5cc6abecb851
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @example {\"paperSize\":\"A4\",\"duplex\":false,\"color\":true}
     *
     * @var string
     */
    public $printInfo;

    /**
     * @description This parameter is required.
     *
     * @example PRINTER1
     *
     * @var string
     */
    public $printerCode;

    /**
     * @description This parameter is required.
     *
     * @example 数学
     *
     * @var string
     */
    public $subjectName;

    /**
     * @description This parameter is required.
     *
     * @example DING_GRADING_1
     *
     * @var string
     */
    public $taskCode;

    /**
     * @description This parameter is required.
     *
     * @example 80
     *
     * @var int
     */
    public $totalPages;
    protected $_name = [
        'allAssignmentPdfUrl' => 'allAssignmentPdfUrl',
        'className' => 'className',
        'corpId' => 'corpId',
        'printInfo' => 'printInfo',
        'printerCode' => 'printerCode',
        'subjectName' => 'subjectName',
        'taskCode' => 'taskCode',
        'totalPages' => 'totalPages',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->allAssignmentPdfUrl) {
            $res['allAssignmentPdfUrl'] = $this->allAssignmentPdfUrl;
        }
        if (null !== $this->className) {
            $res['className'] = $this->className;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->printInfo) {
            $res['printInfo'] = $this->printInfo;
        }
        if (null !== $this->printerCode) {
            $res['printerCode'] = $this->printerCode;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }
        if (null !== $this->totalPages) {
            $res['totalPages'] = $this->totalPages;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateAwaitingCorrectionDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allAssignmentPdfUrl'])) {
            $model->allAssignmentPdfUrl = $map['allAssignmentPdfUrl'];
        }
        if (isset($map['className'])) {
            $model->className = $map['className'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['printInfo'])) {
            $model->printInfo = $map['printInfo'];
        }
        if (isset($map['printerCode'])) {
            $model->printerCode = $map['printerCode'];
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }
        if (isset($map['totalPages'])) {
            $model->totalPages = $map['totalPages'];
        }

        return $model;
    }
}
