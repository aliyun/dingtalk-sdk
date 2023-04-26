<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFileUploadInfoResponseBody extends Model
{
    /**
     * @example xxx
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @example xxx
     *
     * @var string
     */
    public $accessKeySecret;

    /**
     * @example xxx
     *
     * @var string
     */
    public $accessToken;

    /**
     * @example 1626923829000
     *
     * @var int
     */
    public $accessTokenExpirationMillis;

    /**
     * @example lippi-space-zjk
     *
     * @var string
     */
    public $bucket;

    /**
     * @example oss-cn-zhangjiakou.aliyuncs.com
     *
     * @var string
     */
    public $endPoint;

    /**
     * @example xxx
     *
     * @var string
     */
    public $mediaId;
    protected $_name = [
        'accessKeyId'                 => 'accessKeyId',
        'accessKeySecret'             => 'accessKeySecret',
        'accessToken'                 => 'accessToken',
        'accessTokenExpirationMillis' => 'accessTokenExpirationMillis',
        'bucket'                      => 'bucket',
        'endPoint'                    => 'endPoint',
        'mediaId'                     => 'mediaId',
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
        if (null !== $this->accessToken) {
            $res['accessToken'] = $this->accessToken;
        }
        if (null !== $this->accessTokenExpirationMillis) {
            $res['accessTokenExpirationMillis'] = $this->accessTokenExpirationMillis;
        }
        if (null !== $this->bucket) {
            $res['bucket'] = $this->bucket;
        }
        if (null !== $this->endPoint) {
            $res['endPoint'] = $this->endPoint;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileUploadInfoResponseBody
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
        if (isset($map['accessToken'])) {
            $model->accessToken = $map['accessToken'];
        }
        if (isset($map['accessTokenExpirationMillis'])) {
            $model->accessTokenExpirationMillis = $map['accessTokenExpirationMillis'];
        }
        if (isset($map['bucket'])) {
            $model->bucket = $map['bucket'];
        }
        if (isset($map['endPoint'])) {
            $model->endPoint = $map['endPoint'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }

        return $model;
    }
}
