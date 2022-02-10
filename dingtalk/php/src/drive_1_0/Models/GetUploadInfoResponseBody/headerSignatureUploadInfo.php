<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponseBody;

use AlibabaCloud\Tea\Model;

class headerSignatureUploadInfo extends Model
{
    /**
     * @description 上传地址
     *
     * @var string
     */
    public $resourceUrl;

    /**
     * @description 内网上传地址
     *
     * @var string
     */
    public $internalResourceUrl;

    /**
     * @description 过期秒数
     *
     * @var int
     */
    public $expirationSeconds;

    /**
     * @description header加签信息
     *
     * @var mixed[]
     */
    public $headers;

    /**
     * @description mediaId
     *
     * @var string
     */
    public $mediaId;
    protected $_name = [
        'resourceUrl'         => 'resourceUrl',
        'internalResourceUrl' => 'internalResourceUrl',
        'expirationSeconds'   => 'expirationSeconds',
        'headers'             => 'headers',
        'mediaId'             => 'mediaId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->resourceUrl) {
            $res['resourceUrl'] = $this->resourceUrl;
        }
        if (null !== $this->internalResourceUrl) {
            $res['internalResourceUrl'] = $this->internalResourceUrl;
        }
        if (null !== $this->expirationSeconds) {
            $res['expirationSeconds'] = $this->expirationSeconds;
        }
        if (null !== $this->headers) {
            $res['headers'] = $this->headers;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return headerSignatureUploadInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['resourceUrl'])) {
            $model->resourceUrl = $map['resourceUrl'];
        }
        if (isset($map['internalResourceUrl'])) {
            $model->internalResourceUrl = $map['internalResourceUrl'];
        }
        if (isset($map['expirationSeconds'])) {
            $model->expirationSeconds = $map['expirationSeconds'];
        }
        if (isset($map['headers'])) {
            $model->headers = $map['headers'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }

        return $model;
    }
}
