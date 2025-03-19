<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomControlPanelListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryMeetingRoomControlPanelListResponseBody\result\roomIotConfig;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 1WADFxxxxxx
     *
     * @var string
     */
    public $roomId;

    /**
     * @var roomIotConfig[]
     */
    public $roomIotConfig;
    protected $_name = [
        'roomId' => 'roomId',
        'roomIotConfig' => 'roomIotConfig',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->roomId) {
            $res['roomId'] = $this->roomId;
        }
        if (null !== $this->roomIotConfig) {
            $res['roomIotConfig'] = [];
            if (null !== $this->roomIotConfig && \is_array($this->roomIotConfig)) {
                $n = 0;
                foreach ($this->roomIotConfig as $item) {
                    $res['roomIotConfig'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['roomId'])) {
            $model->roomId = $map['roomId'];
        }
        if (isset($map['roomIotConfig'])) {
            if (!empty($map['roomIotConfig'])) {
                $model->roomIotConfig = [];
                $n = 0;
                foreach ($map['roomIotConfig'] as $item) {
                    $model->roomIotConfig[$n++] = null !== $item ? roomIotConfig::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
