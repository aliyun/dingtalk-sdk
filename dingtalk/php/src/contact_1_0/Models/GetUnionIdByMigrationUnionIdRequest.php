<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetUnionIdByMigrationUnionIdRequest extends Model
{
    /**
     * @description migrationUnionId
     *
     * @var string
     */
    public $migrationUnionId;
    protected $_name = [
        'migrationUnionId' => 'migrationUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->migrationUnionId) {
            $res['migrationUnionId'] = $this->migrationUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetUnionIdByMigrationUnionIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['migrationUnionId'])) {
            $model->migrationUnionId = $map['migrationUnionId'];
        }

        return $model;
    }
}
