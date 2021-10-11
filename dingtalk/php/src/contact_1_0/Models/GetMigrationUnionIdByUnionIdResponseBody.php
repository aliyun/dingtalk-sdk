<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMigrationUnionIdByUnionIdResponseBody extends Model
{
    /**
     * @description migrationUnionIdList
     *
     * @var mixed[]
     */
    public $migrationUnionIdList;
    protected $_name = [
        'migrationUnionIdList' => 'migrationUnionIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->migrationUnionIdList) {
            $res['migrationUnionIdList'] = $this->migrationUnionIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMigrationUnionIdByUnionIdResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['migrationUnionIdList'])) {
            $model->migrationUnionIdList = $map['migrationUnionIdList'];
        }

        return $model;
    }
}
