<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signers\orgInfo;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signers\signComponentConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signers\signConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signers\signerInfo;
use AlibabaCloud\Tea\Model;

class signers extends Model
{
    /**
     * @var string
     */
    public $bizTaskId;

    /**
     * @var orgInfo
     */
    public $orgInfo;

    /**
     * @var signComponentConfig[]
     */
    public $signComponentConfig;

    /**
     * @var signConfig
     */
    public $signConfig;

    /**
     * @var signerInfo
     */
    public $signerInfo;

    /**
     * @var string
     */
    public $signerType;
    protected $_name = [
        'bizTaskId' => 'bizTaskId',
        'orgInfo' => 'orgInfo',
        'signComponentConfig' => 'signComponentConfig',
        'signConfig' => 'signConfig',
        'signerInfo' => 'signerInfo',
        'signerType' => 'signerType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTaskId) {
            $res['bizTaskId'] = $this->bizTaskId;
        }
        if (null !== $this->orgInfo) {
            $res['orgInfo'] = null !== $this->orgInfo ? $this->orgInfo->toMap() : null;
        }
        if (null !== $this->signComponentConfig) {
            $res['signComponentConfig'] = [];
            if (null !== $this->signComponentConfig && \is_array($this->signComponentConfig)) {
                $n = 0;
                foreach ($this->signComponentConfig as $item) {
                    $res['signComponentConfig'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->signConfig) {
            $res['signConfig'] = null !== $this->signConfig ? $this->signConfig->toMap() : null;
        }
        if (null !== $this->signerInfo) {
            $res['signerInfo'] = null !== $this->signerInfo ? $this->signerInfo->toMap() : null;
        }
        if (null !== $this->signerType) {
            $res['signerType'] = $this->signerType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTaskId'])) {
            $model->bizTaskId = $map['bizTaskId'];
        }
        if (isset($map['orgInfo'])) {
            $model->orgInfo = orgInfo::fromMap($map['orgInfo']);
        }
        if (isset($map['signComponentConfig'])) {
            if (!empty($map['signComponentConfig'])) {
                $model->signComponentConfig = [];
                $n = 0;
                foreach ($map['signComponentConfig'] as $item) {
                    $model->signComponentConfig[$n++] = null !== $item ? signComponentConfig::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['signConfig'])) {
            $model->signConfig = signConfig::fromMap($map['signConfig']);
        }
        if (isset($map['signerInfo'])) {
            $model->signerInfo = signerInfo::fromMap($map['signerInfo']);
        }
        if (isset($map['signerType'])) {
            $model->signerType = $map['signerType'];
        }

        return $model;
    }
}
