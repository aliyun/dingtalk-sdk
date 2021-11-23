<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponseBody\headerSignatureUploadInfo;
use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponseBody\stsUploadInfo;
use AlibabaCloud\Tea\Model;

class GetUploadInfoResponseBody extends Model
{
    /**
     * @var stsUploadInfo
     */
    public $stsUploadInfo;

    /**
     * @var headerSignatureUploadInfo
     */
    public $headerSignatureUploadInfo;
    protected $_name = [
        'stsUploadInfo'             => 'stsUploadInfo',
        'headerSignatureUploadInfo' => 'headerSignatureUploadInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->stsUploadInfo) {
            $res['stsUploadInfo'] = null !== $this->stsUploadInfo ? $this->stsUploadInfo->toMap() : null;
        }
        if (null !== $this->headerSignatureUploadInfo) {
            $res['headerSignatureUploadInfo'] = null !== $this->headerSignatureUploadInfo ? $this->headerSignatureUploadInfo->toMap() : null;
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
        if (isset($map['stsUploadInfo'])) {
            $model->stsUploadInfo = stsUploadInfo::fromMap($map['stsUploadInfo']);
        }
        if (isset($map['headerSignatureUploadInfo'])) {
            $model->headerSignatureUploadInfo = headerSignatureUploadInfo::fromMap($map['headerSignatureUploadInfo']);
        }

        return $model;
    }
}
