<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class FileStorageGetStorageStateResponseBody extends Model
{
    /**
     * @var string
     */
    public $accessKeyId;

    /**
     * @var string
     */
    public $createDate;

    /**
     * @var int
     */
    public $fileStorageOpenStatus;

    /**
     * @var string
     */
    public $oss;

    /**
     * @var int
     */
    public $storageStatus;

    /**
     * @var int
     */
    public $usedQuota;
    protected $_name = [
        'accessKeyId' => 'accessKeyId',
        'createDate' => 'createDate',
        'fileStorageOpenStatus' => 'fileStorageOpenStatus',
        'oss' => 'oss',
        'storageStatus' => 'storageStatus',
        'usedQuota' => 'usedQuota',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accessKeyId) {
            $res['accessKeyId'] = $this->accessKeyId;
        }
        if (null !== $this->createDate) {
            $res['createDate'] = $this->createDate;
        }
        if (null !== $this->fileStorageOpenStatus) {
            $res['fileStorageOpenStatus'] = $this->fileStorageOpenStatus;
        }
        if (null !== $this->oss) {
            $res['oss'] = $this->oss;
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
     * @return FileStorageGetStorageStateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accessKeyId'])) {
            $model->accessKeyId = $map['accessKeyId'];
        }
        if (isset($map['createDate'])) {
            $model->createDate = $map['createDate'];
        }
        if (isset($map['fileStorageOpenStatus'])) {
            $model->fileStorageOpenStatus = $map['fileStorageOpenStatus'];
        }
        if (isset($map['oss'])) {
            $model->oss = $map['oss'];
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
