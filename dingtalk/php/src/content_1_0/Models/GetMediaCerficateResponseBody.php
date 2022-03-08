<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMediaCerficateResponseBody extends Model
{
    /**
     * @description 媒体文件ID
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description 上传授权密钥ID
     *
     * @var string
     */
    public $ossAccessKeyId;

    /**
     * @description 上传授权密钥
     *
     * @var string
     */
    public $ossAccessKeySecret;

    /**
     * @description OSS Bucket名称
     *
     * @var string
     */
    public $ossBucketName;

    /**
     * @description OSS区域地址
     *
     * @var string
     */
    public $ossEndpoint;

    /**
     * @description 凭证有效时间(单位秒)，当上传凭证过期时，需要重新使用本次返回的videoId重新调用接口进行凭证刷新
     *
     * @var string
     */
    public $ossExpiration;

    /**
     * @description 分配的媒体文件名
     *
     * @var string
     */
    public $ossFileName;

    /**
     * @description 上传授权安全令牌
     *
     * @var string
     */
    public $ossSecurityToken;
    protected $_name = [
        'mediaId'            => 'mediaId',
        'ossAccessKeyId'     => 'ossAccessKeyId',
        'ossAccessKeySecret' => 'ossAccessKeySecret',
        'ossBucketName'      => 'ossBucketName',
        'ossEndpoint'        => 'ossEndpoint',
        'ossExpiration'      => 'ossExpiration',
        'ossFileName'        => 'ossFileName',
        'ossSecurityToken'   => 'ossSecurityToken',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->ossAccessKeyId) {
            $res['ossAccessKeyId'] = $this->ossAccessKeyId;
        }
        if (null !== $this->ossAccessKeySecret) {
            $res['ossAccessKeySecret'] = $this->ossAccessKeySecret;
        }
        if (null !== $this->ossBucketName) {
            $res['ossBucketName'] = $this->ossBucketName;
        }
        if (null !== $this->ossEndpoint) {
            $res['ossEndpoint'] = $this->ossEndpoint;
        }
        if (null !== $this->ossExpiration) {
            $res['ossExpiration'] = $this->ossExpiration;
        }
        if (null !== $this->ossFileName) {
            $res['ossFileName'] = $this->ossFileName;
        }
        if (null !== $this->ossSecurityToken) {
            $res['ossSecurityToken'] = $this->ossSecurityToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMediaCerficateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['ossAccessKeyId'])) {
            $model->ossAccessKeyId = $map['ossAccessKeyId'];
        }
        if (isset($map['ossAccessKeySecret'])) {
            $model->ossAccessKeySecret = $map['ossAccessKeySecret'];
        }
        if (isset($map['ossBucketName'])) {
            $model->ossBucketName = $map['ossBucketName'];
        }
        if (isset($map['ossEndpoint'])) {
            $model->ossEndpoint = $map['ossEndpoint'];
        }
        if (isset($map['ossExpiration'])) {
            $model->ossExpiration = $map['ossExpiration'];
        }
        if (isset($map['ossFileName'])) {
            $model->ossFileName = $map['ossFileName'];
        }
        if (isset($map['ossSecurityToken'])) {
            $model->ossSecurityToken = $map['ossSecurityToken'];
        }

        return $model;
    }
}
