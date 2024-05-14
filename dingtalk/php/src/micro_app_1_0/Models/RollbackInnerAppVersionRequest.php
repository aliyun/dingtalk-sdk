<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models;

use AlibabaCloud\Tea\Model;

class RollbackInnerAppVersionRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $appVersionId;

    /**
     * @description This parameter is required.
     *
     * @example xxx
     *
     * @var string
     */
    public $opUnionId;
    protected $_name = [
        'appVersionId' => 'appVersionId',
        'opUnionId'    => 'opUnionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appVersionId) {
            $res['appVersionId'] = $this->appVersionId;
        }
        if (null !== $this->opUnionId) {
            $res['opUnionId'] = $this->opUnionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RollbackInnerAppVersionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appVersionId'])) {
            $model->appVersionId = $map['appVersionId'];
        }
        if (isset($map['opUnionId'])) {
            $model->opUnionId = $map['opUnionId'];
        }

        return $model;
    }
}
