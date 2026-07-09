<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signDocs;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signers;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signFlowConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signFlowInitiator;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signTasks;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $bizFlowId;

    /**
     * @var int
     */
    public $createTime;

    /**
     * @var int
     */
    public $finishTime;

    /**
     * @var string
     */
    public $initiateUrl;

    /**
     * @var signDocs[]
     */
    public $signDocs;

    /**
     * @var signFlowConfig
     */
    public $signFlowConfig;

    /**
     * @var string
     */
    public $signFlowId;

    /**
     * @var signFlowInitiator
     */
    public $signFlowInitiator;

    /**
     * @var string
     */
    public $signFlowStatus;

    /**
     * @var signTasks[]
     */
    public $signTasks;

    /**
     * @var signers[]
     */
    public $signers;

    /**
     * @var int
     */
    public $startTime;
    protected $_name = [
        'bizFlowId' => 'bizFlowId',
        'createTime' => 'createTime',
        'finishTime' => 'finishTime',
        'initiateUrl' => 'initiateUrl',
        'signDocs' => 'signDocs',
        'signFlowConfig' => 'signFlowConfig',
        'signFlowId' => 'signFlowId',
        'signFlowInitiator' => 'signFlowInitiator',
        'signFlowStatus' => 'signFlowStatus',
        'signTasks' => 'signTasks',
        'signers' => 'signers',
        'startTime' => 'startTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizFlowId) {
            $res['bizFlowId'] = $this->bizFlowId;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->initiateUrl) {
            $res['initiateUrl'] = $this->initiateUrl;
        }
        if (null !== $this->signDocs) {
            $res['signDocs'] = [];
            if (null !== $this->signDocs && \is_array($this->signDocs)) {
                $n = 0;
                foreach ($this->signDocs as $item) {
                    $res['signDocs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->signFlowConfig) {
            $res['signFlowConfig'] = null !== $this->signFlowConfig ? $this->signFlowConfig->toMap() : null;
        }
        if (null !== $this->signFlowId) {
            $res['signFlowId'] = $this->signFlowId;
        }
        if (null !== $this->signFlowInitiator) {
            $res['signFlowInitiator'] = null !== $this->signFlowInitiator ? $this->signFlowInitiator->toMap() : null;
        }
        if (null !== $this->signFlowStatus) {
            $res['signFlowStatus'] = $this->signFlowStatus;
        }
        if (null !== $this->signTasks) {
            $res['signTasks'] = [];
            if (null !== $this->signTasks && \is_array($this->signTasks)) {
                $n = 0;
                foreach ($this->signTasks as $item) {
                    $res['signTasks'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->signers) {
            $res['signers'] = [];
            if (null !== $this->signers && \is_array($this->signers)) {
                $n = 0;
                foreach ($this->signers as $item) {
                    $res['signers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizFlowId'])) {
            $model->bizFlowId = $map['bizFlowId'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['initiateUrl'])) {
            $model->initiateUrl = $map['initiateUrl'];
        }
        if (isset($map['signDocs'])) {
            if (!empty($map['signDocs'])) {
                $model->signDocs = [];
                $n = 0;
                foreach ($map['signDocs'] as $item) {
                    $model->signDocs[$n++] = null !== $item ? signDocs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['signFlowConfig'])) {
            $model->signFlowConfig = signFlowConfig::fromMap($map['signFlowConfig']);
        }
        if (isset($map['signFlowId'])) {
            $model->signFlowId = $map['signFlowId'];
        }
        if (isset($map['signFlowInitiator'])) {
            $model->signFlowInitiator = signFlowInitiator::fromMap($map['signFlowInitiator']);
        }
        if (isset($map['signFlowStatus'])) {
            $model->signFlowStatus = $map['signFlowStatus'];
        }
        if (isset($map['signTasks'])) {
            if (!empty($map['signTasks'])) {
                $model->signTasks = [];
                $n = 0;
                foreach ($map['signTasks'] as $item) {
                    $model->signTasks[$n++] = null !== $item ? signTasks::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['signers'])) {
            if (!empty($map['signers'])) {
                $model->signers = [];
                $n = 0;
                foreach ($map['signers'] as $item) {
                    $model->signers[$n++] = null !== $item ? signers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
