<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class HrmCorpConfigQueryRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example policy
     *
     * @var string
     */
    public $subType;

    /**
     * @description This parameter is required.
     *
     * @example hrm_ai
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'subType' => 'subType',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->subType) {
            $res['subType'] = $this->subType;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HrmCorpConfigQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subType'])) {
            $model->subType = $map['subType'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
