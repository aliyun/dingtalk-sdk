<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeviceHeartbeatResponseBody extends Model
{
    /**
     * @example 0心跳正常，1增量更新，2上传日志，3全量更新
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
