<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponseBody\stsUploadInfo;
use AlibabaCloud\Tea\Model;

class GetUploadInfoResponseBody extends Model
{
    /**
     * @var stsUploadInfo
     */
    public $stsUploadInfo;
    protected $_name = [
        'stsUploadInfo' => 'stsUploadInfo',
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

        return $model;
    }
}
