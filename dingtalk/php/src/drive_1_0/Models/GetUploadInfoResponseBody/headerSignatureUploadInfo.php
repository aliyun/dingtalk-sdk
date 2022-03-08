<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponseBody;

use AlibabaCloud\Tea\Model;

class headerSignatureUploadInfo extends Model
{
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
     * @description 内网上传地址
     *
     * @var string
     */
    public $internalResourceUrl;

    /**
     * @description mediaId
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description 上传地址
     *
     * @var string
     */
    public $resourceUrl;
    protected $_name = [
        'expirationSeconds'   => 'expirationSeconds',
        'headers'             => 'headers',
        'internalResourceUrl' => 'internalResourceUrl',
        'mediaId'             => 'mediaId',
        'resourceUrl'         => 'resourceUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->expirationSeconds) {
            $res['expirationSeconds'] = $this->expirationSeconds;
        }
        if (null !== $this->headers) {
            $res['headers'] = $this->headers;
        }
        if (null !== $this->internalResourceUrl) {
            $res['internalResourceUrl'] = $this->internalResourceUrl;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->resourceUrl) {
            $res['resourceUrl'] = $this->resourceUrl;
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
        if (isset($map['expirationSeconds'])) {
            $model->expirationSeconds = $map['expirationSeconds'];
        }
        if (isset($map['headers'])) {
            $model->headers = $map['headers'];
        }
        if (isset($map['internalResourceUrl'])) {
            $model->internalResourceUrl = $map['internalResourceUrl'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['resourceUrl'])) {
            $model->resourceUrl = $map['resourceUrl'];
        }

        return $model;
    }
}
