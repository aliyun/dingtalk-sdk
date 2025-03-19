<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryFormByBizTypeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example SWAPP-abcdef-example
     *
     * @var string
     */
    public $appUuid;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $bizTypes;
    protected $_name = [
        'appUuid' => 'appUuid',
        'bizTypes' => 'bizTypes',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUuid) {
            $res['appUuid'] = $this->appUuid;
        }
        if (null !== $this->bizTypes) {
            $res['bizTypes'] = $this->bizTypes;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryFormByBizTypeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUuid'])) {
            $model->appUuid = $map['appUuid'];
        }
        if (isset($map['bizTypes'])) {
            if (!empty($map['bizTypes'])) {
                $model->bizTypes = $map['bizTypes'];
            }
        }

        return $model;
    }
}
