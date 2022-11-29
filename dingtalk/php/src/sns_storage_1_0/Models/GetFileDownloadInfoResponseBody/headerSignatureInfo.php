<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetFileDownloadInfoResponseBody;

use AlibabaCloud\Tea\Model;

class headerSignatureInfo extends Model
{
    /**
     * @description 过期时间，单位秒
     *
     * @var int
     */
    public $expirationSeconds;

    /**
     * @description 请求头
     * 20
     * @var string[]
     */
    public $headers;

    /**
     * @description 内网URL, 在网络连通的情况下，使用内网URL可加速服务器间上传
     * 10
     * @var string[]
     */
    public $internalResourceUrls;

    /**
     * @description 地域
     * UNKNOWN: 未知
     * @var string
     */
    public $region;

    /**
     * @description 多个上传下载URL, 前面url优先
     * 10
     * @var string[]
     */
    public $resourceUrls;
    protected $_name = [
        'expirationSeconds'    => 'expirationSeconds',
        'headers'              => 'headers',
        'internalResourceUrls' => 'internalResourceUrls',
        'region'               => 'region',
        'resourceUrls'         => 'resourceUrls',
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
