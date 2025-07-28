<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapp_market_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetInAppSkuUrlRequest extends Model
{
    /**
     * @var string
     */
    public $callbackPage;

    /**
     * @var string
     */
    public $extendParam;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $goodsCode;

    /**
     * @var string
     */
    public $itemCode;
    protected $_name = [
        'callbackPage' => 'callbackPage',
        'extendParam' => 'extendParam',
        'goodsCode' => 'goodsCode',
        'itemCode' => 'itemCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->callbackPage) {
            $res['callbackPage'] = $this->callbackPage;
        }
        if (null !== $this->extendParam) {
            $res['extendParam'] = $this->extendParam;
        }
        if (null !== $this->goodsCode) {
            $res['goodsCode'] = $this->goodsCode;
        }
        if (null !== $this->itemCode) {
            $res['itemCode'] = $this->itemCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetInAppSkuUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callbackPage'])) {
            $model->callbackPage = $map['callbackPage'];
        }
        if (isset($map['extendParam'])) {
            $model->extendParam = $map['extendParam'];
        }
        if (isset($map['goodsCode'])) {
            $model->goodsCode = $map['goodsCode'];
        }
        if (isset($map['itemCode'])) {
            $model->itemCode = $map['itemCode'];
        }

        return $model;
    }
}
