<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetImportEncryptPublicKeyResponseBody extends Model
{
    /**
     * @var string
     */
    public $algorithm;

    /**
     * @var int
     */
    public $expireAt;

    /**
     * @var string
     */
    public $keyVersion;

    /**
     * @var string
     */
    public $publicKeyPem;
    protected $_name = [
        'algorithm' => 'algorithm',
        'expireAt' => 'expireAt',
        'keyVersion' => 'keyVersion',
        'publicKeyPem' => 'publicKeyPem',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->algorithm) {
            $res['algorithm'] = $this->algorithm;
        }
        if (null !== $this->expireAt) {
            $res['expireAt'] = $this->expireAt;
        }
        if (null !== $this->keyVersion) {
            $res['keyVersion'] = $this->keyVersion;
        }
        if (null !== $this->publicKeyPem) {
            $res['publicKeyPem'] = $this->publicKeyPem;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetImportEncryptPublicKeyResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['algorithm'])) {
            $model->algorithm = $map['algorithm'];
        }
        if (isset($map['expireAt'])) {
            $model->expireAt = $map['expireAt'];
        }
        if (isset($map['keyVersion'])) {
            $model->keyVersion = $map['keyVersion'];
        }
        if (isset($map['publicKeyPem'])) {
            $model->publicKeyPem = $map['publicKeyPem'];
        }

        return $model;
    }
}
