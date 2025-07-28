<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryRolesRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $dentryUuidList;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'dentryUuidList' => 'dentryUuidList',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryUuidList) {
            $res['dentryUuidList'] = $this->dentryUuidList;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryRolesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryUuidList'])) {
            if (!empty($map['dentryUuidList'])) {
                $model->dentryUuidList = $map['dentryUuidList'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
