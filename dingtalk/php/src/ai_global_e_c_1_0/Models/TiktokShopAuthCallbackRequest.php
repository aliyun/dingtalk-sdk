<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\Tea\Model;

class TiktokShopAuthCallbackRequest extends Model
{
    /**
     * @var string
     */
    public $sellerType;

    /**
     * @var string
     */
    public $shopId;

    /**
     * @var string
     */
    public $shopName;

    /**
     * @var string
     */
    public $shopRegion;
    protected $_name = [
        'sellerType' => 'sellerType',
        'shopId' => 'shopId',
        'shopName' => 'shopName',
        'shopRegion' => 'shopRegion',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sellerType) {
            $res['sellerType'] = $this->sellerType;
        }
        if (null !== $this->shopId) {
            $res['shopId'] = $this->shopId;
        }
        if (null !== $this->shopName) {
            $res['shopName'] = $this->shopName;
        }
        if (null !== $this->shopRegion) {
            $res['shopRegion'] = $this->shopRegion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TiktokShopAuthCallbackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sellerType'])) {
            $model->sellerType = $map['sellerType'];
        }
        if (isset($map['shopId'])) {
            $model->shopId = $map['shopId'];
        }
        if (isset($map['shopName'])) {
            $model->shopName = $map['shopName'];
        }
        if (isset($map['shopRegion'])) {
            $model->shopRegion = $map['shopRegion'];
        }

        return $model;
    }
}
