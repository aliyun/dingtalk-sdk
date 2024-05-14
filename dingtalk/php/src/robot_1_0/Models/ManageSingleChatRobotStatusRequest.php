<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class ManageSingleChatRobotStatusRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingykcdkjnwpcll27gm
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description This parameter is required.
     *
     * @example enable
     *
     * @var string
     */
    public $status;
    protected $_name = [
        'robotCode' => 'robotCode',
        'status'    => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ManageSingleChatRobotStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
