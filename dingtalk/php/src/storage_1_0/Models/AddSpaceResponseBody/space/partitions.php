<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceResponseBody\space;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceResponseBody\space\partitions\quota;
use AlibabaCloud\Tea\Model;

class partitions extends Model
{
    /**
     * @example PUBLIC_OSS_PARTITION
     *
     * @var string
     */
    public $partitionType;

    /**
     * @var quota
     */
    public $quota;
    protected $_name = [
        'partitionType' => 'partitionType',
        'quota' => 'quota',
    ];

    public function validate() {}

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
