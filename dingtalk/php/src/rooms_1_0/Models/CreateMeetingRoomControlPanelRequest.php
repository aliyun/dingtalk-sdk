<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomControlPanelRequest\extra;
use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\CreateMeetingRoomControlPanelRequest\roomConfig;
use AlibabaCloud\Tea\Model;

class CreateMeetingRoomControlPanelRequest extends Model
{
    /**
     * @var extra
     */
    public $extra;

    /**
     * @description This parameter is required.
     *
     * @var roomConfig[]
     */
    public $roomConfig;

    /**
     * @description This parameter is required.
     *
     * @example 25SDWxxxxxx
     *
     * @var string
     */
    public $roomId;

    /**
     * @example 0
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'extra'      => 'extra',
        'roomConfig' => 'roomConfig',
        'roomId'     => 'roomId',
        'status'     => 'status',
        'unionId'    => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extra) {
            $res['extra'] = null !== $this->extra ? $this->extra->toMap() : null;
        }
        if (null !== $this->roomConfig) {
            $res['roomConfig'] = [];
            if (null !== $this->roomConfig && \is_array($this->roomConfig)) {
                $n = 0;
                foreach ($this->roomConfig as $item) {
                    $res['roomConfig'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->roomId) {
            $res['roomId'] = $this->roomId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateMeetingRoomControlPanelRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extra'])) {
            $model->extra = extra::fromMap($map['extra']);
        }
        if (isset($map['roomConfig'])) {
            if (!empty($map['roomConfig'])) {
                $model->roomConfig = [];
                $n                 = 0;
                foreach ($map['roomConfig'] as $item) {
                    $model->roomConfig[$n++] = null !== $item ? roomConfig::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['roomId'])) {
            $model->roomId = $map['roomId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
