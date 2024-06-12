<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_2_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteRecordsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $recordIds;
    protected $_name = [
        'recordIds' => 'recordIds',
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

        return $model;
    }
}
