<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenObjectiveRuleScopeDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 82347xxx2382
     *
     * @var string
     */
    public $scopeId;

    /**
     * @description This parameter is required.
     *
     * @example USER
     *
     * @var string
     */
    public $scopeType;
    protected $_name = [
        'scopeId' => 'scopeId',
        'scopeType' => 'scopeType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->scopeId) {
            $res['scopeId'] = $this->scopeId;
        }
        if (null !== $this->scopeType) {
            $res['scopeType'] = $this->scopeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenObjectiveRuleScopeDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['scopeId'])) {
            $model->scopeId = $map['scopeId'];
        }
        if (isset($map['scopeType'])) {
            $model->scopeType = $map['scopeType'];
        }

        return $model;
    }
}
