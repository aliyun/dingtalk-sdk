<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponseBody;

use AlibabaCloud\Tea\Model;

class stsUploadInfo extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $accessKeyId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $accessKeySecret;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $accessToken;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $accessTokenExpirationMillis;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bucket;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $endPoint;

    /**
     * @var string
     */
    public $internalEndPoint;

    /**
     * @description This parameter is required.
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
        'internalEndPoint'            => 'internalEndPoint',
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
        if (null !== $this->internalEndPoint) {
            $res['internalEndPoint'] = $this->internalEndPoint;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return stsUploadInfo
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
        if (isset($map['internalEndPoint'])) {
            $model->internalEndPoint = $map['internalEndPoint'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }

        return $model;
    }
}
