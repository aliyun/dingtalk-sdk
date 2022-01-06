<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeviceHeartbeatResponseBody extends Model
{
    /**
     * @description 指令
     *
     * @var int
     */
    public $command;
    protected $_name = [
        'command' => 'command',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->command) {
            $res['command'] = $this->command;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeviceHeartbeatResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['command'])) {
            $model->command = $map['command'];
        }

        return $model;
    }
}
