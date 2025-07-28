<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryRolesRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $dentryIdList;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'dentryIdList' => 'dentryIdList',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryIdList) {
            $res['dentryIdList'] = $this->dentryIdList;
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
        if (isset($map['dentryIdList'])) {
            if (!empty($map['dentryIdList'])) {
                $model->dentryIdList = $map['dentryIdList'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
