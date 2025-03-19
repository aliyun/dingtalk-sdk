<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateHrmVersionRollBackStatusRequest extends Model
{
    /**
     * @example show
     *
     * @var string
     */
    public $configValue;

    /**
     * @example 1231231232
     *
     * @var string
     */
    public $optUserId;
    protected $_name = [
        'configValue' => 'configValue',
        'optUserId' => 'optUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->configValue) {
            $res['configValue'] = $this->configValue;
        }
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateHrmVersionRollBackStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['configValue'])) {
            $model->configValue = $map['configValue'];
        }
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }

        return $model;
    }
}
