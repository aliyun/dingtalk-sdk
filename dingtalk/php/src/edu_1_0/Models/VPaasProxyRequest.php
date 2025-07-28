<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class VPaasProxyRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example init
     *
     * @var string
     */
    public $actionCode;

    /**
     * @description This parameter is required.
     *
     * @example {"a":"testA","b":"testB"}
     *
     * @var string
     */
    public $params;

    /**
     * @description This parameter is required.
     *
     * @example MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCVGpgpjjbBS1Pg1tYx23KDJiXokVdKFLdJznKxQe+fZcIOtcQDIYrfrBfHmiC/gASeF5NUTSrwjkr/i/2gqhIIxRinNJQm8L4GJ6fRGjN8tND7AfhfkGYIfOJCLFSiaYSa4TCM7WsmztkpR7DSvb4P+K/ppqYFfUB46a9nCcvecQIDAQAB
     *
     * @var string
     */
    public $publicKey;
    protected $_name = [
        'actionCode' => 'actionCode',
        'params' => 'params',
        'publicKey' => 'publicKey',
    ];

    public function validate() {}

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
