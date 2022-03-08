<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetApplicationRegFormByFlowIdResponseBody extends Model
{
    /**
     * @description 候选人标识
     *
     * @var string
     */
    public $candidateId;

    /**
     * @description 邀填人员工标识
     *
     * @var string
     */
    public $creatorUserId;

    /**
     * @description 招聘流程标识
     *
     * @var string
     */
    public $flowId;

    /**
     * @description 表单标识
     *
     * @var string
     */
    public $formId;

    /**
     * @description 创建时间（邀填时间，单位：毫秒）
     *
     * @var int
     */
    public $gmtCreateMillis;

    /**
     * @description 更新时间（填写时间，单位：毫秒），仅当表单状态为已填写时有效
     *
     * @var int
     */
    public $gmtModifiedMillis;

    /**
     * @description 职位标识
     *
     * @var string
     */
    public $jobId;

    /**
     * @description 表单状态（0表示未填写，1表示已填写）
     *
     * @var int
     */
    public $status;

    /**
     * @description 模板标识
     *
     * @var string
     */
    public $templateId;

    /**
     * @description 模板版本
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
