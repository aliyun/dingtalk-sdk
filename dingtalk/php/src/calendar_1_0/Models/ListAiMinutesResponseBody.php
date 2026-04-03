<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAiMinutesResponseBody\minutes;
use AlibabaCloud\Tea\Model;

class ListAiMinutesResponseBody extends Model
{
    /**
     * @var minutes[]
     */
    public $minutes;
    protected $_name = [
        'minutes' => 'minutes',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->minutes) {
            $res['minutes'] = [];
            if (null !== $this->minutes && \is_array($this->minutes)) {
                $n = 0;
                foreach ($this->minutes as $item) {
                    $res['minutes'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListAiMinutesResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['minutes'])) {
            if (!empty($map['minutes'])) {
                $model->minutes = [];
                $n = 0;
                foreach ($map['minutes'] as $item) {
                    $model->minutes[$n++] = null !== $item ? minutes::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
