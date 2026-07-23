<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrade_1_0\Models\PurchaseMixViewResponseBody\result;

use AlibabaCloud\Tea\Model;

class recommendedMarketingCollocationDTO extends Model
{
    /**
     * @var int
     */
    public $activityId;

    /**
     * @var int
     */
    public $couponId;
    protected $_name = [
        'activityId' => 'activityId',
        'couponId' => 'couponId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->activityId) {
            $res['activityId'] = $this->activityId;
        }
        if (null !== $this->couponId) {
            $res['couponId'] = $this->couponId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recommendedMarketingCollocationDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['activityId'])) {
            $model->activityId = $map['activityId'];
        }
        if (isset($map['couponId'])) {
            $model->couponId = $map['couponId'];
        }

        return $model;
    }
}
