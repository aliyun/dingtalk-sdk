<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoResponseBody;

use AlibabaCloud\Tea\Model;

class headerSignatureInfo extends Model
{
    /**
     * @example 900
     *
     * @var int
     */
    public $expirationSeconds;

    /**
     * @var string[]
     */
    public $headers;

    /**
     * @var string[]
     */
    public $internalResourceUrls;

    /**
     * @example ZHANGJIAKOU
     *
     * @var string
     */
    public $region;

    /**
     * @var string[]
     */
    public $resourceUrls;
    protected $_name = [
        'expirationSeconds' => 'expirationSeconds',
        'headers' => 'headers',
        'internalResourceUrls' => 'internalResourceUrls',
        'region' => 'region',
        'resourceUrls' => 'resourceUrls',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->expirationSeconds) {
            $res['expirationSeconds'] = $this->expirationSeconds;
        }
        if (null !== $this->headers) {
            $res['headers'] = $this->headers;
        }
        if (null !== $this->internalResourceUrls) {
            $res['internalResourceUrls'] = $this->internalResourceUrls;
        }
        if (null !== $this->region) {
            $res['region'] = $this->region;
        }
        if (null !== $this->resourceUrls) {
            $res['resourceUrls'] = $this->resourceUrls;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return headerSignatureInfo
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
        if (isset($map['internalResourceUrls'])) {
            if (!empty($map['internalResourceUrls'])) {
                $model->internalResourceUrls = $map['internalResourceUrls'];
            }
        }
        if (isset($map['region'])) {
            $model->region = $map['region'];
        }
        if (isset($map['resourceUrls'])) {
            if (!empty($map['resourceUrls'])) {
                $model->resourceUrls = $map['resourceUrls'];
            }
        }

        return $model;
    }
}
