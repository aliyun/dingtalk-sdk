<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signers;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateSignFlowRequest\signers\signComponentConfig\signFieldComponentConfig;
use AlibabaCloud\Tea\Model;

class signComponentConfig extends Model
{
    /**
     * @var string
     */
    public $fileId;

    /**
     * @var signFieldComponentConfig
     */
    public $signFieldComponentConfig;
    protected $_name = [
        'fileId' => 'fileId',
        'signFieldComponentConfig' => 'signFieldComponentConfig',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->signFieldComponentConfig) {
            $res['signFieldComponentConfig'] = null !== $this->signFieldComponentConfig ? $this->signFieldComponentConfig->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return signComponentConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['signFieldComponentConfig'])) {
            $model->signFieldComponentConfig = signFieldComponentConfig::fromMap($map['signFieldComponentConfig']);
        }

        return $model;
    }
}
