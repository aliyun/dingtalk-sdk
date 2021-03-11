<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetUserHolidaysResponseBody\result\holidays;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 员工id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 假期列表
     *
     * @var holidays[]
     */
    public $holidays;
    protected $_name = [
        'userId'   => 'userId',
        'holidays' => 'holidays',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->holidays) {
            $res['holidays'] = [];
            if (null !== $this->holidays && \is_array($this->holidays)) {
                $n = 0;
                foreach ($this->holidays as $item) {
                    $res['holidays'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['holidays'])) {
            if (!empty($map['holidays'])) {
                $model->holidays = [];
                $n               = 0;
                foreach ($map['holidays'] as $item) {
                    $model->holidays[$n++] = null !== $item ? holidays::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
