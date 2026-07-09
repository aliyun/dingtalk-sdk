<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signDocs;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signers;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signFlowConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signFlowInitiator;
use AlibabaCloud\Tea\Model;

class CreateSignFlowRequest extends Model
{
    /**
     * @var string
     */
    public $bizFlowId;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var signDocs[]
     */
    public $signDocs;

    /**
     * @var signFlowConfig
     */
    public $signFlowConfig;

    /**
     * @var signFlowInitiator
     */
    public $signFlowInitiator;

    /**
     * @var signers[]
     */
    public $signers;
    protected $_name = [
        'bizFlowId' => 'bizFlowId',
        'requestId' => 'requestId',
        'signDocs' => 'signDocs',
        'signFlowConfig' => 'signFlowConfig',
        'signFlowInitiator' => 'signFlowInitiator',
        'signers' => 'signers',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizFlowId) {
            $res['bizFlowId'] = $this->bizFlowId;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
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
        if (null !== $this->signFlowInitiator) {
            $res['signFlowInitiator'] = null !== $this->signFlowInitiator ? $this->signFlowInitiator->toMap() : null;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateSignFlowRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizFlowId'])) {
            $model->bizFlowId = $map['bizFlowId'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
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
        if (isset($map['signFlowInitiator'])) {
            $model->signFlowInitiator = signFlowInitiator::fromMap($map['signFlowInitiator']);
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

        return $model;
    }
}
