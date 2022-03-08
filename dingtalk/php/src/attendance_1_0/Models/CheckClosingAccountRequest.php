<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\CheckClosingAccountRequest\userTimeRange;
use AlibabaCloud\Tea\Model;

class CheckClosingAccountRequest extends Model
{
    /**
     * @description 情景
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description 员工列表
     *
     * @var string[]
     */
    public $userIds;

    /**
     * @description 时间段
     *
     * @var userTimeRange[]
     */
    public $userTimeRange;
    protected $_name = [
        'bizCode'       => 'bizCode',
        'userIds'       => 'userIds',
        'userTimeRange' => 'userTimeRange',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->userTimeRange) {
            $res['userTimeRange'] = [];
            if (null !== $this->userTimeRange && \is_array($this->userTimeRange)) {
                $n = 0;
                foreach ($this->userTimeRange as $item) {
                    $res['userTimeRange'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckClosingAccountRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['userTimeRange'])) {
            if (!empty($map['userTimeRange'])) {
                $model->userTimeRange = [];
                $n                    = 0;
                foreach ($map['userTimeRange'] as $item) {
                    $model->userTimeRange[$n++] = null !== $item ? userTimeRange::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
