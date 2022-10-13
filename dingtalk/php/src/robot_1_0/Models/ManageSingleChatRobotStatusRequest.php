<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class ManageSingleChatRobotStatusRequest extends Model
{
    /**
     * @description 钉钉开放平台后台机器人的robotCode
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 机器人的可用状态，enable-启用、disable-停用
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
