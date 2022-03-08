<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo;

use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo\payInfo\csUserInfo;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo\payInfo\discountInfo;
use AlibabaCloud\Tea\Model;

class payInfo extends Model
{
    /**
     * @description 客服身份信息
     *
     * @var csUserInfo
     */
    public $csUserInfo;

    /**
     * @description 课程打折信息
     *
     * @var discountInfo
     */
    public $discountInfo;

    /**
     * @description 商品的默认情况下非打折时的价格，单位为分
     *
     * @var int
     */
    public $price;
    protected $_name = [
        'csUserInfo'   => 'csUserInfo',
        'discountInfo' => 'discountInfo',
        'price'        => 'price',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->csUserInfo) {
            $res['csUserInfo'] = null !== $this->csUserInfo ? $this->csUserInfo->toMap() : null;
        }
        if (null !== $this->discountInfo) {
            $res['discountInfo'] = null !== $this->discountInfo ? $this->discountInfo->toMap() : null;
        }
        if (null !== $this->price) {
            $res['price'] = $this->price;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return payInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['csUserInfo'])) {
            $model->csUserInfo = csUserInfo::fromMap($map['csUserInfo']);
        }
        if (isset($map['discountInfo'])) {
            $model->discountInfo = discountInfo::fromMap($map['discountInfo']);
        }
        if (isset($map['price'])) {
            $model->price = $map['price'];
        }

        return $model;
    }
}
