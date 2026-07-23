<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetServiceInvocationRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $invocationId;
    protected $_name = [
        'invocationId' => 'invocationId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->invocationId) {
            $res['invocationId'] = $this->invocationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetServiceInvocationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['invocationId'])) {
            $model->invocationId = $map['invocationId'];
        }

        return $model;
    }
}
