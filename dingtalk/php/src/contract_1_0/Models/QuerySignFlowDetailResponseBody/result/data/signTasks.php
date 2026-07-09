<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signTasks\orgInfo;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signTasks\signerInfo;
use AlibabaCloud\Tea\Model;

class signTasks extends Model
{
    /**
     * @var int
     */
    public $activateTime;

    /**
     * @var string
     */
    public $actualOrgSealType;

    /**
     * @var string
     */
    public $actualPsnSealType;

    /**
     * @var string
     */
    public $bizTaskId;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var int
     */
    public $finishTime;

    /**
     * @var orgInfo
     */
    public $orgInfo;

    /**
     * @var int
     */
    public $signOrder;

    /**
     * @var string
     */
    public $signTaskId;

    /**
     * @var string
     */
    public $signUrl;

    /**
     * @var signerInfo
     */
    public $signerInfo;

    /**
     * @var string
     */
    public $signerType;

    /**
     * @var string
     */
    public $taskStatus;
    protected $_name = [
        'activateTime' => 'activateTime',
        'actualOrgSealType' => 'actualOrgSealType',
        'actualPsnSealType' => 'actualPsnSealType',
        'bizTaskId' => 'bizTaskId',
        'createTime' => 'createTime',
        'finishTime' => 'finishTime',
        'orgInfo' => 'orgInfo',
        'signOrder' => 'signOrder',
        'signTaskId' => 'signTaskId',
        'signUrl' => 'signUrl',
        'signerInfo' => 'signerInfo',
        'signerType' => 'signerType',
        'taskStatus' => 'taskStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activateTime) {
            $res['activateTime'] = $this->activateTime;
        }
        if (null !== $this->actualOrgSealType) {
            $res['actualOrgSealType'] = $this->actualOrgSealType;
        }
        if (null !== $this->actualPsnSealType) {
            $res['actualPsnSealType'] = $this->actualPsnSealType;
        }
        if (null !== $this->bizTaskId) {
            $res['bizTaskId'] = $this->bizTaskId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->orgInfo) {
            $res['orgInfo'] = null !== $this->orgInfo ? $this->orgInfo->toMap() : null;
        }
        if (null !== $this->signOrder) {
            $res['signOrder'] = $this->signOrder;
        }
        if (null !== $this->signTaskId) {
            $res['signTaskId'] = $this->signTaskId;
        }
        if (null !== $this->signUrl) {
            $res['signUrl'] = $this->signUrl;
        }
        if (null !== $this->signerInfo) {
            $res['signerInfo'] = null !== $this->signerInfo ? $this->signerInfo->toMap() : null;
        }
        if (null !== $this->signerType) {
            $res['signerType'] = $this->signerType;
        }
        if (null !== $this->taskStatus) {
            $res['taskStatus'] = $this->taskStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signTasks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activateTime'])) {
            $model->activateTime = $map['activateTime'];
        }
        if (isset($map['actualOrgSealType'])) {
            $model->actualOrgSealType = $map['actualOrgSealType'];
        }
        if (isset($map['actualPsnSealType'])) {
            $model->actualPsnSealType = $map['actualPsnSealType'];
        }
        if (isset($map['bizTaskId'])) {
            $model->bizTaskId = $map['bizTaskId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['orgInfo'])) {
            $model->orgInfo = orgInfo::fromMap($map['orgInfo']);
        }
        if (isset($map['signOrder'])) {
            $model->signOrder = $map['signOrder'];
        }
        if (isset($map['signTaskId'])) {
            $model->signTaskId = $map['signTaskId'];
        }
        if (isset($map['signUrl'])) {
            $model->signUrl = $map['signUrl'];
        }
        if (isset($map['signerInfo'])) {
            $model->signerInfo = signerInfo::fromMap($map['signerInfo']);
        }
        if (isset($map['signerType'])) {
            $model->signerType = $map['signerType'];
        }
        if (isset($map['taskStatus'])) {
            $model->taskStatus = $map['taskStatus'];
        }

        return $model;
    }
}
