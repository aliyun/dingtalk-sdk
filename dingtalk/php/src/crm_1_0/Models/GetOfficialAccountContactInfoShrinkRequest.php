<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOfficialAccountContactInfoShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $contextShrink;
    protected $_name = [
        'contextShrink' => 'context',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contextShrink) {
            $res['context'] = $this->contextShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOfficialAccountContactInfoShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['context'])) {
            $model->contextShrink = $map['context'];
        }

        return $model;
    }
}
