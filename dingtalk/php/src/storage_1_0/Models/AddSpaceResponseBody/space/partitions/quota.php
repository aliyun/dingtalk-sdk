<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceResponseBody\space\partitions;

use AlibabaCloud\Tea\Model;

class quota extends Model
{
    /**
     * @description 最大容量, 单位: Byte
     * 当前应用容量未设置max时，返回空，此时应用共享该企业剩余可用容量
     * @var int
     */
    public $max;

    /**
     * @description 预分配剩余容量, 单位: Byte
     * 如果没有设置预分配容，此字段是空
     * @var int
     */
    public $reserved;

    /**
     * @description 容量类型
     * 使用场景：需要保证单个应用的可用容量不受其他应用影响时, 可使用预分配容量（专享容量）
     * @var string
     */
    public $type;

    /**
     * @description 实际已使用容量, 单位: Byte
     * 0
     * @var int
     */
    public $used;
    protected $_name = [
        'max'      => 'max',
        'reserved' => 'reserved',
        'type'     => 'type',
        'used'     => 'used',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->max) {
            $res['max'] = $this->max;
        }
        if (null !== $this->reserved) {
            $res['reserved'] = $this->reserved;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->used) {
            $res['used'] = $this->used;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return quota
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['max'])) {
            $model->max = $map['max'];
        }
        if (isset($map['reserved'])) {
            $model->reserved = $map['reserved'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['used'])) {
            $model->used = $map['used'];
        }

        return $model;
    }
}
