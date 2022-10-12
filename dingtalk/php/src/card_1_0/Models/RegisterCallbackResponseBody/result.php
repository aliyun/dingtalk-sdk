<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\RegisterCallbackResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description api 签名密钥
     *
     * @var string
     */
    public $apiSecret;

    /**
     * @description ISV 接受动态卡片点击的回调地址
     *
     * @var string
     */
    public $callbackUrl;
    protected $_name = [
        'apiSecret'   => 'apiSecret',
        'callbackUrl' => 'callbackUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->apiSecret) {
            $res['apiSecret'] = $this->apiSecret;
        }
        if (null !== $this->callbackUrl) {
            $res['callbackUrl'] = $this->callbackUrl;
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
        if (isset($map['apiSecret'])) {
            $model->apiSecret = $map['apiSecret'];
        }
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
        }

        return $model;
    }
}
