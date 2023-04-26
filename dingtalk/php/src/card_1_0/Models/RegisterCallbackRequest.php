<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\Tea\Model;

class RegisterCallbackRequest extends Model
{
    /**
     * @example mySecret
     *
     * @var string
     */
    public $apiSecret;

    /**
     * @example routeKey-12
     *
     * @var string
     */
    public $callbackRouteKey;

    /**
     * @example https://www.myurl/callback
     *
     * @var string
     */
    public $callbackUrl;

    /**
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
