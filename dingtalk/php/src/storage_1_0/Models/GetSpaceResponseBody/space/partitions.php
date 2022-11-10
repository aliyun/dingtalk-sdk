<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetSpaceResponseBody\space;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetSpaceResponseBody\space\partitions\quota;
use AlibabaCloud\Tea\Model;

class partitions extends Model
{
    /**
     * @description 分区类型
     * MINI_OSS_PARTITION: 专属Mini OSS存储分区
     * @var string
     */
    public $partitionType;

    /**
     * @description 容量信息
     *
     * @var quota
     */
    public $quota;
    protected $_name = [
        'partitionType' => 'partitionType',
        'quota'         => 'quota',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->partitionType) {
            $res['partitionType'] = $this->partitionType;
        }
        if (null !== $this->quota) {
            $res['quota'] = null !== $this->quota ? $this->quota->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return partitions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['partitionType'])) {
            $model->partitionType = $map['partitionType'];
        }
        if (isset($map['quota'])) {
            $model->quota = quota::fromMap($map['quota']);
        }

        return $model;
    }
}
