<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetDingIdByMigrationDingIdRequest extends Model
{
    /**
     * @description migrationDingId
     *
     * @var string
     */
    public $migrationDingId;
    protected $_name = [
        'migrationDingId' => 'migrationDingId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->migrationDingId) {
            $res['migrationDingId'] = $this->migrationDingId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDingIdByMigrationDingIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['migrationDingId'])) {
            $model->migrationDingId = $map['migrationDingId'];
        }

        return $model;
    }
}
