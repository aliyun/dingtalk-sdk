<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vsns_storage_1_0\Models\GetDentriesRequest\option;
use AlibabaCloud\Tea\Model;

class GetDentriesRequest extends Model
{
    /**
     * @var string[]
     */
    public $dentryIds;

    /**
     * @var option
     */
    public $option;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'dentryIds' => 'dentryIds',
        'option'    => 'option',
        'unionId'   => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentryIds) {
            $res['dentryIds'] = $this->dentryIds;
        }
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDentriesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentryIds'])) {
            if (!empty($map['dentryIds'])) {
                $model->dentryIds = $map['dentryIds'];
            }
        }
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
