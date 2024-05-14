<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class CallbackRegiesterRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 3b89df4dfaaccd5b8e1f9a2
     *
     * @var string
     */
    public $apiSecret;

    /**
     * @description This parameter is required.
     *
     * @example abc-123
     *
     * @var string
     */
    public $callbackKey;

    /**
     * @description This parameter is required.
     *
     * @example https://www.your.com/callback
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @description This parameter is required.
     *
     * @example shortcut
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'apiSecret'   => 'apiSecret',
        'callbackKey' => 'callbackKey',
        'callbackUrl' => 'callbackUrl',
        'type'        => 'type',
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
        if (null !== $this->callbackKey) {
            $res['callbackKey'] = $this->callbackKey;
        }
        if (null !== $this->callbackUrl) {
            $res['callbackUrl'] = $this->callbackUrl;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CallbackRegiesterRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apiSecret'])) {
            $model->apiSecret = $map['apiSecret'];
        }
        if (isset($map['callbackKey'])) {
            $model->callbackKey = $map['callbackKey'];
        }
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
