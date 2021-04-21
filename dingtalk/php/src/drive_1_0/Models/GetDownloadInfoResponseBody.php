<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoResponseBody\downloadInfo;
use AlibabaCloud\Tea\Model;

class GetDownloadInfoResponseBody extends Model
{
    /**
     * @description 下载加签url信息
     *
     * @var downloadInfo
     */
    public $downloadInfo;
    protected $_name = [
        'downloadInfo' => 'downloadInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadInfo) {
            $res['downloadInfo'] = null !== $this->downloadInfo ? $this->downloadInfo->toMap() : null;
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
        if (isset($map['downloadInfo'])) {
            $model->downloadInfo = downloadInfo::fromMap($map['downloadInfo']);
        }

        return $model;
    }
}
