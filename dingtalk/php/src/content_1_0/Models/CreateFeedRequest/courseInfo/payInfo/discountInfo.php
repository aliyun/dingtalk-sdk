<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo\payInfo;

use AlibabaCloud\Tea\Model;

class discountInfo extends Model
{
    /**
     * @example 1624507431777
     *
     * @var int
     */
    public $endTimeMillis;

    /**
     * @example 100
     *
     * @var int
     */
    public $price;

    /**
     * @example 1624507431777
     *
     * @var int
     */
    public $startTimeMillis;
    protected $_name = [
        'endTimeMillis'   => 'endTimeMillis',
        'price'           => 'price',
        'startTimeMillis' => 'startTimeMillis',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTimeMillis) {
            $res['endTimeMillis'] = $this->endTimeMillis;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }
        if (null !== $this->startTimeMillis) {
            $res['startTimeMillis'] = $this->startTimeMillis;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return discountInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTimeMillis'])) {
            $model->endTimeMillis = $map['endTimeMillis'];
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }
        if (isset($map['startTimeMillis'])) {
            $model->startTimeMillis = $map['startTimeMillis'];
        }

        return $model;
    }
}
