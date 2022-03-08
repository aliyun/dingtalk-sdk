<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysResponseBody\result\holidays;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 假期列表
     *
     * @var holidays[]
     */
    public $holidays;

    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'holidays' => 'holidays',
        'userId'   => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->holidays) {
            $res['holidays'] = [];
            if (null !== $this->holidays && \is_array($this->holidays)) {
                $n = 0;
                foreach ($this->holidays as $item) {
                    $res['holidays'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['holidays'])) {
            if (!empty($map['holidays'])) {
                $model->holidays = [];
                $n               = 0;
                foreach ($map['holidays'] as $item) {
                    $model->holidays[$n++] = null !== $item ? holidays::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
