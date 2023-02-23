<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class CallbackRegiesterRequest extends Model
{
    /**
     * @description 回调API签名生成密钥。
     * 最大长度不超过32个字符。
     * @var string
     */
    public $apiSecret;

    /**
     * @description 回调key，由调用者定义，需要确保同一服务窗帐号下的唯一性。
     * 最长不超过32个字符。
     * @var string
     */
    public $callbackKey;

    /**
     * @description 回调URL。暂不支持附带queryString的URL
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @description 回调类型，支持互动卡片、应用快捷入口、吊顶卡片等。
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
