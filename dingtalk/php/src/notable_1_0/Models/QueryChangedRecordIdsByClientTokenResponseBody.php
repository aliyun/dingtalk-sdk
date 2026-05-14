<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryChangedRecordIdsByClientTokenResponseBody extends Model
{
    /**
     * @var mixed
     */
    public $changedRecordIds;
    protected $_name = [
        'changedRecordIds' => 'changedRecordIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->changedRecordIds) {
            $res['changedRecordIds'] = $this->changedRecordIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryChangedRecordIdsByClientTokenResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['changedRecordIds'])) {
            $model->changedRecordIds = $map['changedRecordIds'];
        }

        return $model;
    }
}
