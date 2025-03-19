<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetFileDownloadInfoByPackageIdRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $packageId;
    protected $_name = [
        'packageId' => 'packageId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->packageId) {
            $res['packageId'] = $this->packageId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileDownloadInfoByPackageIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['packageId'])) {
            $model->packageId = $map['packageId'];
        }

        return $model;
    }
}
