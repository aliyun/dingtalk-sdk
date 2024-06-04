<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetInAppPurchaseGoodsResponseBody\result\purchaseGoodsList;

use AlibabaCloud\Tea\Model;

class mainOperationInfo extends Model
{
    /**
     * @example GOODS-002
     *
     * @var string
     */
    public $goodsCode;

    /**
     * @example https://yyy
     *
     * @var string
     */
    public $originalUrl;

    /**
     * @example https://xxx
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'goodsCode'   => 'goodsCode',
        'originalUrl' => 'originalUrl',
        'url'         => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->goodsCode) {
            $res['goodsCode'] = $this->goodsCode;
        }
        if (null !== $this->originalUrl) {
            $res['originalUrl'] = $this->originalUrl;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return mainOperationInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['goodsCode'])) {
            $model->goodsCode = $map['goodsCode'];
        }
        if (isset($map['originalUrl'])) {
            $model->originalUrl = $map['originalUrl'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
