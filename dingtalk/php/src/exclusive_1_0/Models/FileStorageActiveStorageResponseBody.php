<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class FileStorageActiveStorageResponseBody extends Model
{
    /**
     * @description oss开启时间
     *
     * @var string
     */
    public $createDate;

    /**
     * @description 是否开启专属存储 0开启1关闭
     *
     * @var int
     */
    public $fileStorageOpenStatus;

    /**
     * @description 存储状态 0正常1异常
     *
     * @var int
     */
    public $storageStatus;

    /**
     * @description 已经使用的容量Bytes
     *
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'createDate'            => 'createDate',
        'fileStorageOpenStatus' => 'fileStorageOpenStatus',
        'storageStatus'         => 'storageStatus',
        'usedQuota'             => 'usedQuota',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createDate) {
            $res['createDate'] = $this->createDate;
        }
        if (null !== $this->fileStorageOpenStatus) {
            $res['fileStorageOpenStatus'] = $this->fileStorageOpenStatus;
        }
        if (null !== $this->storageStatus) {
            $res['storageStatus'] = $this->storageStatus;
        }
        if (null !== $this->usedQuota) {
            $res['usedQuota'] = $this->usedQuota;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FileStorageActiveStorageResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createDate'])) {
            $model->createDate = $map['createDate'];
        }
        if (isset($map['fileStorageOpenStatus'])) {
            $model->fileStorageOpenStatus = $map['fileStorageOpenStatus'];
        }
        if (isset($map['storageStatus'])) {
            $model->storageStatus = $map['storageStatus'];
        }
        if (isset($map['usedQuota'])) {
            $model->usedQuota = $map['usedQuota'];
        }

        return $model;
    }
}
