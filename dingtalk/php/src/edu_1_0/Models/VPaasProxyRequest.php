<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class VPaasProxyRequest extends Model
{
    /**
     * @description 代理操作码
     *
     * @var string
     */
    public $actionCode;

    /**
     * @description 调用参数
     *
     * @var string
     */
    public $params;

    /**
     * @description Base64加密的公钥
     *
     * @var string
     */
    public $publicKey;
    protected $_name = [
        'actionCode' => 'actionCode',
        'params'     => 'params',
        'publicKey'  => 'publicKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionCode) {
            $res['actionCode'] = $this->actionCode;
        }
        if (null !== $this->params) {
            $res['params'] = $this->params;
        }
        if (null !== $this->publicKey) {
            $res['publicKey'] = $this->publicKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return VPaasProxyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionCode'])) {
            $model->actionCode = $map['actionCode'];
        }
        if (isset($map['params'])) {
            $model->params = $map['params'];
        }
        if (isset($map['publicKey'])) {
            $model->publicKey = $map['publicKey'];
        }

        return $model;
    }
}
