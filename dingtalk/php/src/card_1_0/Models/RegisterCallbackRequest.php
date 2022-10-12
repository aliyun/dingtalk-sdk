<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterCallbackRequest extends Model
{
    /**
     * @description 加密密钥用于校验来源
     *
     * @var string
     */
    public $apiSecret;

    /**
     * @description callbackUrl 的路由 Key，一个 callbackRouteKey 可以映射一个 callbackUrl
     *
     * @var string
     */
    public $callbackRouteKey;

    /**
     * @description 注册的回调 URL
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @description 是否强制覆盖更新，默认 false
     *
     * @var bool
     */
    public $forceUpdate;
    protected $_name = [
        'apiSecret'        => 'apiSecret',
        'callbackRouteKey' => 'callbackRouteKey',
        'callbackUrl'      => 'callbackUrl',
        'forceUpdate'      => 'forceUpdate',
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
        if (null !== $this->callbackRouteKey) {
            $res['callbackRouteKey'] = $this->callbackRouteKey;
        }
        if (null !== $this->callbackUrl) {
            $res['callbackUrl'] = $this->callbackUrl;
        }
        if (null !== $this->forceUpdate) {
            $res['forceUpdate'] = $this->forceUpdate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RegisterCallbackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apiSecret'])) {
            $model->apiSecret = $map['apiSecret'];
        }
        if (isset($map['callbackRouteKey'])) {
            $model->callbackRouteKey = $map['callbackRouteKey'];
        }
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
        }
        if (isset($map['forceUpdate'])) {
            $model->forceUpdate = $map['forceUpdate'];
        }

        return $model;
    }
}
