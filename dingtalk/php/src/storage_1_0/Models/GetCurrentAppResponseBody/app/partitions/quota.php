<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetCurrentAppResponseBody\app\partitions;

use AlibabaCloud\Tea\Model;

class quota extends Model
{
    /**
     * @example 10000
     *
     * @var int
     */
    public $max;

    /**
     * @example 1000
     *
     * @var int
     */
    public $reserved;

    /**
     * @example SHARE
     *
     * @var string
     */
    public $type;

    /**
     * @example 1024
     *
     * @var int
     */
    public $used;
    protected $_name = [
        'max' => 'max',
        'reserved' => 'reserved',
        'type' => 'type',
        'used' => 'used',
    ];

    public function validate() {}

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
