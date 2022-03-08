<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponseBody\headerSignatureUploadInfo;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponseBody\stsUploadInfo;
use AlibabaCloud\Tea\Model;

class GetUploadInfoResponseBody extends Model
{
    /**
     * @var headerSignatureUploadInfo
     */
    public $headerSignatureUploadInfo;

    /**
     * @description 文件所存储的区域
     *
     * @var string
     */
    public $region;

    /**
     * @var stsUploadInfo
     */
    public $stsUploadInfo;
    protected $_name = [
        'headerSignatureUploadInfo' => 'headerSignatureUploadInfo',
        'region'                    => 'region',
        'stsUploadInfo'             => 'stsUploadInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->headerSignatureUploadInfo) {
            $res['headerSignatureUploadInfo'] = null !== $this->headerSignatureUploadInfo ? $this->headerSignatureUploadInfo->toMap() : null;
        }
        if (null !== $this->region) {
            $res['region'] = $this->region;
        }
        if (null !== $this->stsUploadInfo) {
            $res['stsUploadInfo'] = null !== $this->stsUploadInfo ? $this->stsUploadInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUploadInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['headerSignatureUploadInfo'])) {
            $model->headerSignatureUploadInfo = headerSignatureUploadInfo::fromMap($map['headerSignatureUploadInfo']);
        }
        if (isset($map['region'])) {
            $model->region = $map['region'];
        }
        if (isset($map['stsUploadInfo'])) {
            $model->stsUploadInfo = stsUploadInfo::fromMap($map['stsUploadInfo']);
        }

        return $model;
    }
}
