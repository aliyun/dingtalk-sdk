<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateReviewChecklistShrinkRequest extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $rulesShrink;
    protected $_name = [
        'corpId' => 'corp_id',
        'name' => 'name',
        'rulesShrink' => 'rules',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corp_id'] = $this->corpId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->rulesShrink) {
            $res['rules'] = $this->rulesShrink;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateReviewChecklistShrinkRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corp_id'])) {
            $model->corpId = $map['corp_id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['rules'])) {
            $model->rulesShrink = $map['rules'];
        }

        return $model;
    }
}
