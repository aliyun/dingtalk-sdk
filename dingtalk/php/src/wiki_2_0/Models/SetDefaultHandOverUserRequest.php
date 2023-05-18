<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\Tea\Model;

class SetDefaultHandOverUserRequest extends Model
{
    /**
     * @example staff_id
     *
     * @var string
     */
    public $defaultHandoverUserId;

    /**
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'defaultHandoverUserId' => 'defaultHandoverUserId',
        'operatorId'            => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->defaultHandoverUserId) {
            $res['defaultHandoverUserId'] = $this->defaultHandoverUserId;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetDefaultHandOverUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['defaultHandoverUserId'])) {
            $model->defaultHandoverUserId = $map['defaultHandoverUserId'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
