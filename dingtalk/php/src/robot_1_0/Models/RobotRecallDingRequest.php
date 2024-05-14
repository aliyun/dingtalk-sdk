<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class RobotRecallDingRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $openDingId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'openDingId' => 'openDingId',
        'robotCode'  => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openDingId) {
            $res['openDingId'] = $this->openDingId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RobotRecallDingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['openDingId'])) {
            $model->openDingId = $map['openDingId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
