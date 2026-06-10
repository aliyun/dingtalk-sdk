<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\ExecuteImportRequest;

use AlibabaCloud\Tea\Model;

class encryption extends Model
{
    /**
     * @var string
     */
    public $algorithm;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $encryptedAesKey;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $iv;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $keyVersion;
    protected $_name = [
        'algorithm' => 'algorithm',
        'encryptedAesKey' => 'encryptedAesKey',
        'iv' => 'iv',
        'keyVersion' => 'keyVersion',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->algorithm) {
            $res['algorithm'] = $this->algorithm;
        }
        if (null !== $this->encryptedAesKey) {
            $res['encryptedAesKey'] = $this->encryptedAesKey;
        }
        if (null !== $this->iv) {
            $res['iv'] = $this->iv;
        }
        if (null !== $this->keyVersion) {
            $res['keyVersion'] = $this->keyVersion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return encryption
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['algorithm'])) {
            $model->algorithm = $map['algorithm'];
        }
        if (isset($map['encryptedAesKey'])) {
            $model->encryptedAesKey = $map['encryptedAesKey'];
        }
        if (isset($map['iv'])) {
            $model->iv = $map['iv'];
        }
        if (isset($map['keyVersion'])) {
            $model->keyVersion = $map['keyVersion'];
        }

        return $model;
    }
}
