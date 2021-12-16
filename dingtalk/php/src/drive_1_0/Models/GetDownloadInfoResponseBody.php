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

    /**
     * @description 文件所存储的区域
     *
     * @var string
     */
    public $region;
    protected $_name = [
        'downloadInfo' => 'downloadInfo',
        'region'       => 'region',
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
        if (null !== $this->region) {
            $res['region'] = $this->region;
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
        if (isset($map['region'])) {
            $model->region = $map['region'];
        }

        return $model;
    }
}
