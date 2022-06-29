<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncSecretKeyResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 验签加密串
     *
     * @var string
     */
    public $secretString;

    /**
     * @description 钉钉侧对应的组织ID
     *
     * @var string
     */
    public $targetCorpId;

    /**
     * @description 商旅侧对接key
     *
     * @var string
     */
    public $tripAppKey;

    /**
     * @description 商旅侧对接密钥
     *
     * @var string
     */
    public $tripAppSecurity;

    /**
     * @description 商旅侧对应的组织ID
     *
     * @var string
     */
    public $tripCorpId;
    protected $_name = [
        'secretString'    => 'secretString',
        'targetCorpId'    => 'targetCorpId',
        'tripAppKey'      => 'tripAppKey',
        'tripAppSecurity' => 'tripAppSecurity',
        'tripCorpId'      => 'tripCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->secretString) {
            $res['secretString'] = $this->secretString;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }
        if (null !== $this->tripAppKey) {
            $res['tripAppKey'] = $this->tripAppKey;
        }
        if (null !== $this->tripAppSecurity) {
            $res['tripAppSecurity'] = $this->tripAppSecurity;
        }
        if (null !== $this->tripCorpId) {
            $res['tripCorpId'] = $this->tripCorpId;
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
        if (isset($map['secretString'])) {
            $model->secretString = $map['secretString'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }
        if (isset($map['tripAppKey'])) {
            $model->tripAppKey = $map['tripAppKey'];
        }
        if (isset($map['tripAppSecurity'])) {
            $model->tripAppSecurity = $map['tripAppSecurity'];
        }
        if (isset($map['tripCorpId'])) {
            $model->tripCorpId = $map['tripCorpId'];
        }

        return $model;
    }
}
