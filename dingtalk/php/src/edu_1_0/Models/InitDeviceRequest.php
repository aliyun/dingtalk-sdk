<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class InitDeviceRequest extends Model
{
    /**
     * @example sdf34DFf2344
     *
     * @var string
     */
    public $encryptPubKey;

    /**
     * @example sdf34DFfffdf2344
     *
     * @var string
     */
    public $signature;

    /**
     * @example SN123456
     *
     * @var string
     */
    public $sn;

    /**
     * @example 1231245511
     *
     * @var int
     */
    public $timestamp;

    /**
     * @example 1.0
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'encryptPubKey' => 'encryptPubKey',
        'signature'     => 'signature',
        'sn'            => 'sn',
        'timestamp'     => 'timestamp',
        'version'       => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->encryptPubKey) {
            $res['encryptPubKey'] = $this->encryptPubKey;
        }
        if (null !== $this->signature) {
            $res['signature'] = $this->signature;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return InitDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['encryptPubKey'])) {
            $model->encryptPubKey = $map['encryptPubKey'];
        }
        if (isset($map['signature'])) {
            $model->signature = $map['signature'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
