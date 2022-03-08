<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFileUploadInfoResponseBody extends Model
{
    /**
     * @description OSS上传所需信息：accessKeyId
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @description OSS上传所需信息：accessKeySecret
     *
     * @var string
     */
    public $accessKeySecret;

    /**
     * @description OSS上传所需信息：accessToken
     *
     * @var string
     */
    public $accessToken;

    /**
     * @description accessToken有效期截止时间（单位：毫秒），需要在此时间之前完成文件上传
     *
     * @var int
     */
    public $accessTokenExpirationMillis;

    /**
     * @description OSS上传所需信息：bucket
     *
     * @var string
     */
    public $bucket;

    /**
     * @description OSS上传所需信息：endPoint
     *
     * @var string
     */
    public $endPoint;

    /**
     * @description 文件mediaId
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
