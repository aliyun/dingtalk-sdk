<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMigrationDingIdByDingIdResponseBody extends Model
{
    /**
     * @description migrationDingIdList
     *
     * @var mixed[]
     */
    public $migrationDingIdList;
    protected $_name = [
        'migrationDingIdList' => 'migrationDingIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->migrationDingIdList) {
            $res['migrationDingIdList'] = $this->migrationDingIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMigrationDingIdByDingIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['migrationDingIdList'])) {
            $model->migrationDingIdList = $map['migrationDingIdList'];
        }

        return $model;
    }
}
