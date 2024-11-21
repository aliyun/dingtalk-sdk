<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultResponseBody\tasks\result\items;

use AlibabaCloud\Tea\Model;

class subs extends Model
{
    /**
     * @var int
     */
    public $point;

    /**
     * @var string
     */
    public $reference;

    /**
     * @var string
     */
    public $subInfo;
    protected $_name = [
        'point'     => 'point',
        'reference' => 'reference',
        'subInfo'   => 'subInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->point) {
            $res['point'] = $this->point;
        }
        if (null !== $this->reference) {
            $res['reference'] = $this->reference;
        }
        if (null !== $this->subInfo) {
            $res['subInfo'] = $this->subInfo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['point'])) {
            $model->point = $map['point'];
        }
        if (isset($map['reference'])) {
            $model->reference = $map['reference'];
        }
        if (isset($map['subInfo'])) {
            $model->subInfo = $map['subInfo'];
        }

        return $model;
    }
}
