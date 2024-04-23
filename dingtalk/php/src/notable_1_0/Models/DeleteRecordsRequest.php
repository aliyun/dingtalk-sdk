<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRecordsRequest extends Model
{
    /**
     * @var string[]
     */
    public $recordIds;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'recordIds'  => 'recordIds',
        'operatorId' => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->recordIds) {
            $res['recordIds'] = $this->recordIds;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteRecordsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recordIds'])) {
            if (!empty($map['recordIds'])) {
                $model->recordIds = $map['recordIds'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
