<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signers\signComponentConfig;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signers\signComponentConfig\signFieldComponentConfig\signDateConfig;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QuerySignFlowDetailResponseBody\result\data\signers\signComponentConfig\signFieldComponentConfig\signPositionConfig;
use AlibabaCloud\Tea\Model;

class signFieldComponentConfig extends Model
{
    /**
     * @var string[]
     */
    public $availableOrgSealTypes;

    /**
     * @var string[]
     */
    public $availablePsnSealTypes;

    /**
     * @var string
     */
    public $crossPageType;

    /**
     * @var signDateConfig
     */
    public $signDateConfig;

    /**
     * @var signPositionConfig
     */
    public $signPositionConfig;
    protected $_name = [
        'availableOrgSealTypes' => 'availableOrgSealTypes',
        'availablePsnSealTypes' => 'availablePsnSealTypes',
        'crossPageType' => 'crossPageType',
        'signDateConfig' => 'signDateConfig',
        'signPositionConfig' => 'signPositionConfig',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->availableOrgSealTypes) {
            $res['availableOrgSealTypes'] = $this->availableOrgSealTypes;
        }
        if (null !== $this->availablePsnSealTypes) {
            $res['availablePsnSealTypes'] = $this->availablePsnSealTypes;
        }
        if (null !== $this->crossPageType) {
            $res['crossPageType'] = $this->crossPageType;
        }
        if (null !== $this->signDateConfig) {
            $res['signDateConfig'] = null !== $this->signDateConfig ? $this->signDateConfig->toMap() : null;
        }
        if (null !== $this->signPositionConfig) {
            $res['signPositionConfig'] = null !== $this->signPositionConfig ? $this->signPositionConfig->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signFieldComponentConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['availableOrgSealTypes'])) {
            if (!empty($map['availableOrgSealTypes'])) {
                $model->availableOrgSealTypes = $map['availableOrgSealTypes'];
            }
        }
        if (isset($map['availablePsnSealTypes'])) {
            if (!empty($map['availablePsnSealTypes'])) {
                $model->availablePsnSealTypes = $map['availablePsnSealTypes'];
            }
        }
        if (isset($map['crossPageType'])) {
            $model->crossPageType = $map['crossPageType'];
        }
        if (isset($map['signDateConfig'])) {
            $model->signDateConfig = signDateConfig::fromMap($map['signDateConfig']);
        }
        if (isset($map['signPositionConfig'])) {
            $model->signPositionConfig = signPositionConfig::fromMap($map['signPositionConfig']);
        }

        return $model;
    }
}
