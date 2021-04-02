<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoResponseBody\presignedUrlDownloadInfo;
use AlibabaCloud\Tea\Model;

class GetDownloadInfoResponseBody extends Model
{
    /**
     * @description 下载加签url信息
     *
     * @var presignedUrlDownloadInfo
     */
    public $presignedUrlDownloadInfo;
    protected $_name = [
        'presignedUrlDownloadInfo' => 'presignedUrlDownloadInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->presignedUrlDownloadInfo) {
            $res['presignedUrlDownloadInfo'] = null !== $this->presignedUrlDownloadInfo ? $this->presignedUrlDownloadInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDownloadInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['presignedUrlDownloadInfo'])) {
            $model->presignedUrlDownloadInfo = presignedUrlDownloadInfo::fromMap($map['presignedUrlDownloadInfo']);
        }

        return $model;
    }
}
