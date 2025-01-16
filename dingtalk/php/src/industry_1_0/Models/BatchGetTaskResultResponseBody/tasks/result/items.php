<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultResponseBody\tasks\result;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultResponseBody\tasks\result\items\subs;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @example 主持人有问好，并得到积极回应
     *
     * @var string
     */
    public $info;

    /**
     * @example 是否有问好
     *
     * @var string
     */
    public $name;

    /**
     * @example 10
     *
     * @var int
     */
    public $point;

    /**
     * @var string
     */
    public $reference;

    /**
     * @var string[]
     */
    public $referenceFrame;

    /**
     * @var subs[]
     */
    public $subs;
    protected $_name = [
        'info'           => 'info',
        'name'           => 'name',
        'point'          => 'point',
        'reference'      => 'reference',
        'referenceFrame' => 'referenceFrame',
        'subs'           => 'subs',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->info) {
            $res['info'] = $this->info;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->point) {
            $res['point'] = $this->point;
        }
        if (null !== $this->reference) {
            $res['reference'] = $this->reference;
        }
        if (null !== $this->referenceFrame) {
            $res['referenceFrame'] = $this->referenceFrame;
        }
        if (null !== $this->subs) {
            $res['subs'] = [];
            if (null !== $this->subs && \is_array($this->subs)) {
                $n = 0;
                foreach ($this->subs as $item) {
                    $res['subs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['info'])) {
            $model->info = $map['info'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['point'])) {
            $model->point = $map['point'];
        }
        if (isset($map['reference'])) {
            $model->reference = $map['reference'];
        }
        if (isset($map['referenceFrame'])) {
            if (!empty($map['referenceFrame'])) {
                $model->referenceFrame = $map['referenceFrame'];
            }
        }
        if (isset($map['subs'])) {
            if (!empty($map['subs'])) {
                $model->subs = [];
                $n           = 0;
                foreach ($map['subs'] as $item) {
                    $model->subs[$n++] = null !== $item ? subs::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
