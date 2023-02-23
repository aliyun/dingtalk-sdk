<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\CallbackRegiesterResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 成功注册的api secret
     *
     * @var string
     */
    public $apiSecret;

    /**
     * @description 成功注册的url
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
