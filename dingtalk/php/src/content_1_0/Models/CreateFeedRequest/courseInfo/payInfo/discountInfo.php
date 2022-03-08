<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo\payInfo;

use AlibabaCloud\Tea\Model;

class discountInfo extends Model
{
    /**
     * @description 打折结束的时间，时间戳精确到毫秒，时间为东八区时间
     *
     * @var int
     */
    public $endTimeMillis;

    /**
     * @description 打折时商品的价格，单位为分
     *
     * @var int
     */
    public $price;

    /**
     * @description 打折开始的时间，时间戳精确到毫秒，时间为东八区时间
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
