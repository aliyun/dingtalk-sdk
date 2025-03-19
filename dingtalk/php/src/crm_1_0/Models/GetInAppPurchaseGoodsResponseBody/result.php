<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsResponseBody\result\purchaseGoodsList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example free
     *
     * @var string
     */
    public $orderVersion;

    /**
     * @var purchaseGoodsList[]
     */
    public $purchaseGoodsList;
    protected $_name = [
        'orderVersion' => 'orderVersion',
        'purchaseGoodsList' => 'purchaseGoodsList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->orderVersion) {
            $res['orderVersion'] = $this->orderVersion;
        }
        if (null !== $this->purchaseGoodsList) {
            $res['purchaseGoodsList'] = [];
            if (null !== $this->purchaseGoodsList && \is_array($this->purchaseGoodsList)) {
                $n = 0;
                foreach ($this->purchaseGoodsList as $item) {
                    $res['purchaseGoodsList'][$n++] = null !== $item ? $item->toMap() : $item;
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
        if (isset($map['orderVersion'])) {
            $model->orderVersion = $map['orderVersion'];
        }
        if (isset($map['purchaseGoodsList'])) {
            if (!empty($map['purchaseGoodsList'])) {
                $model->purchaseGoodsList = [];
                $n = 0;
                foreach ($map['purchaseGoodsList'] as $item) {
                    $model->purchaseGoodsList[$n++] = null !== $item ? purchaseGoodsList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
