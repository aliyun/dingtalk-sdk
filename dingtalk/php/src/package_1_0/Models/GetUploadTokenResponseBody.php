<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUploadTokenResponseBody extends Model
{
    /**
     * @description 阿里云OSS SDK初始化配置项
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @description 阿里云OSS SDK初始化配置项
     *
     * @var string
     */
    public $accessKeySecret;

    /**
     * @description 阿里云OSS SDK初始化配置项
     *
     * @var string
     */
    public $bucket;

    /**
     * @description 阿里云OSS SDK初始化配置项
     *
     * @var string
     */
    public $endpoint;

    /**
     * @description 阿里云OSS SDK初始化配置项
     *
     * @var string
     */
    public $expiration;

    /**
     * @description 阿里云OSS SDK初始化配置项
     *
     * @var string
     */
    public $name;

    /**
     * @description 阿里云OSS SDK初始化配置项
     *
     * @var string
     */
    public $region;

    /**
     * @description 阿里云OSS SDK初始化配置项
     *
     * @var string
     */
    public $stsToken;
    protected $_name = [
        'accessKeyId'     => 'accessKeyId',
        'accessKeySecret' => 'accessKeySecret',
        'bucket'          => 'bucket',
        'endpoint'        => 'endpoint',
        'expiration'      => 'expiration',
        'name'            => 'name',
        'region'          => 'region',
        'stsToken'        => 'stsToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKeyId) {
            $res['accessKeyId'] = $this->accessKeyId;
        }
        if (null !== $this->accessKeySecret) {
            $res['accessKeySecret'] = $this->accessKeySecret;
        }
        if (null !== $this->bucket) {
            $res['bucket'] = $this->bucket;
        }
        if (null !== $this->endpoint) {
            $res['endpoint'] = $this->endpoint;
        }
        if (null !== $this->expiration) {
            $res['expiration'] = $this->expiration;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->region) {
            $res['region'] = $this->region;
        }
        if (null !== $this->stsToken) {
            $res['stsToken'] = $this->stsToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUploadTokenResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKeyId'])) {
            $model->accessKeyId = $map['accessKeyId'];
        }
        if (isset($map['accessKeySecret'])) {
            $model->accessKeySecret = $map['accessKeySecret'];
        }
        if (isset($map['bucket'])) {
            $model->bucket = $map['bucket'];
        }
        if (isset($map['endpoint'])) {
            $model->endpoint = $map['endpoint'];
        }
        if (isset($map['expiration'])) {
            $model->expiration = $map['expiration'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['region'])) {
            $model->region = $map['region'];
        }
        if (isset($map['stsToken'])) {
            $model->stsToken = $map['stsToken'];
        }

        return $model;
    }
}
