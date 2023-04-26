<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetApplicationRegFormByFlowIdResponseBody extends Model
{
    /**
     * @example xxx
     *
     * @var string
     */
    public $candidateId;

    /**
     * @example manager5875
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @example flowXXX
     *
     * @var string
     */
    public $flowId;

    /**
     * @example formXXX
     *
     * @var string
     */
    public $formId;

    /**
     * @example 1626775016427
     *
     * @var int
     */
    public $gmtCreateMillis;

    /**
     * @example 1626775016427
     *
     * @var int
     */
    public $gmtModifiedMillis;

    /**
     * @example jobXXX
     *
     * @var string
     */
    public $jobId;

    /**
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @example templateXXX
     *
     * @var string
     */
    public $templateId;

    /**
     * @example 0
     *
     * @var int
     */
    public $templateVersion;
    protected $_name = [
        'candidateId'       => 'candidateId',
        'creatorUserId'     => 'creatorUserId',
        'flowId'            => 'flowId',
        'formId'            => 'formId',
        'gmtCreateMillis'   => 'gmtCreateMillis',
        'gmtModifiedMillis' => 'gmtModifiedMillis',
        'jobId'             => 'jobId',
        'status'            => 'status',
        'templateId'        => 'templateId',
        'templateVersion'   => 'templateVersion',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->candidateId) {
            $res['candidateId'] = $this->candidateId;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }
        if (null !== $this->flowId) {
            $res['flowId'] = $this->flowId;
        }
        if (null !== $this->formId) {
            $res['formId'] = $this->formId;
        }
        if (null !== $this->gmtCreateMillis) {
            $res['gmtCreateMillis'] = $this->gmtCreateMillis;
        }
        if (null !== $this->gmtModifiedMillis) {
            $res['gmtModifiedMillis'] = $this->gmtModifiedMillis;
        }
        if (null !== $this->jobId) {
            $res['jobId'] = $this->jobId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateVersion) {
            $res['templateVersion'] = $this->templateVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetApplicationRegFormByFlowIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['candidateId'])) {
            $model->candidateId = $map['candidateId'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }
        if (isset($map['flowId'])) {
            $model->flowId = $map['flowId'];
        }
        if (isset($map['formId'])) {
            $model->formId = $map['formId'];
        }
        if (isset($map['gmtCreateMillis'])) {
            $model->gmtCreateMillis = $map['gmtCreateMillis'];
        }
        if (isset($map['gmtModifiedMillis'])) {
            $model->gmtModifiedMillis = $map['gmtModifiedMillis'];
        }
        if (isset($map['jobId'])) {
            $model->jobId = $map['jobId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateVersion'])) {
            $model->templateVersion = $map['templateVersion'];
        }

        return $model;
    }
}
