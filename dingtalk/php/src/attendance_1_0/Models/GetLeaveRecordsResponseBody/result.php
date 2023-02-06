<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveRecordsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetLeaveRecordsResponseBody\result\leaveRecords;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 是否有更多结果。
     *
     * @var bool
     */
    public $hasMore;

    /**
     * @description 假期消费记录列表。
     *
     * @var leaveRecords[]
     */
    public $leaveRecords;
    protected $_name = [
        'hasMore'      => 'hasMore',
        'leaveRecords' => 'leaveRecords',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->leaveRecords) {
            $res['leaveRecords'] = [];
            if (null !== $this->leaveRecords && \is_array($this->leaveRecords)) {
                $n = 0;
                foreach ($this->leaveRecords as $item) {
                    $res['leaveRecords'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['leaveRecords'])) {
            if (!empty($map['leaveRecords'])) {
                $model->leaveRecords = [];
                $n                   = 0;
                foreach ($map['leaveRecords'] as $item) {
                    $model->leaveRecords[$n++] = null !== $item ? leaveRecords::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
