<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\GetOfficialAccountContactInfoRequest\context;
use AlibabaCloud\Tea\Model;

class GetOfficialAccountContactInfoRequest extends Model
{
    /**
     * @var context
     */
    public $context;
    protected $_name = [
        'context' => 'context',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->context) {
            $res['context'] = null !== $this->context ? $this->context->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOfficialAccountContactInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['context'])) {
            $model->context = context::fromMap($map['context']);
        }

        return $model;
    }
}
