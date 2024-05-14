<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class BankGatewayInvokeRequest extends Model
{
    /**
     * @example bankHttp
     *
     * @var string
     */
    public $actionType;

    /**
     * @var string
     */
    public $inputData;

    /**
     * @example https://cdc.cmbchina.com/cdcserver/api/v2
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'actionType' => 'actionType',
        'inputData'  => 'inputData',
        'url'        => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->inputData) {
            $res['inputData'] = $this->inputData;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BankGatewayInvokeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['inputData'])) {
            $model->inputData = $map['inputData'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
